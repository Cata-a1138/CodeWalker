using CodeWalker.Properties;
using CodeWalker.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWalker.World
{
    public partial class SettingsForm : Form
    {
        private WorldForm worldForm;

        private KeyBindings keyBindings = new KeyBindings(Settings.Default.KeyBindings);
        private string selKeyBinding = "";
        private Keys selKeyBindingVal = Keys.None;

        private float camSensitivity = Settings.Default.CameraSensitivity;
        private float camSmoothing = Settings.Default.CameraSmoothing;
        private bool mouseinvert = Settings.Default.MouseInvert;


        public SettingsForm(WorldForm owner)
        {
            InitializeComponent();

            worldForm = owner;

            var allkeys = Enum.GetValues(typeof(Keys));
            foreach (var keyval in allkeys)
            {
                KeyBindingComboBox.Items.Add(keyval);
            }

            LoadKeyBindings();

            LoadMouseSettings();

            LoadAdvancedSettings();
        }

        private void LoadKeyBindings()
        {
            KeyBindingsListView.Items.Clear();
            AddKeyBinding("向前移动", keyBindings.MoveForward);
            AddKeyBinding("向后移动", keyBindings.MoveBackward);
            AddKeyBinding("向左移动", keyBindings.MoveLeft);
            AddKeyBinding("向右移动", keyBindings.MoveRight);
            AddKeyBinding("向上移动", keyBindings.MoveUp);
            AddKeyBinding("向下移动", keyBindings.MoveDown);
            AddKeyBinding("降低移动速度 / 放大", keyBindings.MoveSlowerZoomIn);
            AddKeyBinding("增加移动速度 / 缩小", keyBindings.MoveFasterZoomOut);
            AddKeyBinding("切换鼠标选择", keyBindings.ToggleMouseSelect);
            AddKeyBinding("切换工具栏", keyBindings.ToggleToolbar);
            AddKeyBinding("退出编辑模式", keyBindings.ExitEditMode);
            AddKeyBinding("编辑位置", keyBindings.EditPosition);
            AddKeyBinding("编辑旋转", keyBindings.EditRotation);
            AddKeyBinding("编辑缩放", keyBindings.EditScale);
            AddKeyBinding("第一人称模式", keyBindings.FirstPerson);

        }
        private void LoadMouseSettings()
        {
            CameraSensitivityUpDown.Value = (decimal)camSensitivity * 1000;
            CameraSmoothingUpDown.Value = (decimal)camSmoothing;
            MouseInvertCheckBox.Checked = mouseinvert;
        }
        private void LoadAdvancedSettings()
        {
            FolderTextBox.Text = GTAFolder.CurrentGTAFolder;
            ExcludeFoldersTextBox.Text = Settings.Default.ExcludeFolders;
            ShadowCascadesUpDown.Value = Settings.Default.ShadowCascades;
            CacheSizeUpDown.Value = Math.Min(Math.Max(Settings.Default.CacheSize / 1048576, CacheSizeUpDown.Minimum), CacheSizeUpDown.Maximum);
            CacheTimeUpDown.Value = Math.Min(Math.Max((decimal)Settings.Default.CacheTime, CacheTimeUpDown.Minimum), CacheTimeUpDown.Maximum);
            GPUCacheTimeUpDown.Value = Math.Min(Math.Max((decimal)Settings.Default.GPUCacheTime, GPUCacheTimeUpDown.Minimum), GPUCacheTimeUpDown.Maximum);
            GPUFlushTimeUpDown.Value = Math.Min(Math.Max((decimal)Settings.Default.GPUCacheFlushTime, GPUFlushTimeUpDown.Minimum), GPUFlushTimeUpDown.Maximum);
            GeometryCacheSizeUpDown.Value = Math.Min(Math.Max(Settings.Default.GPUGeometryCacheSize / 1048576, GeometryCacheSizeUpDown.Minimum), GeometryCacheSizeUpDown.Maximum);
            TextureCacheSizeUpDown.Value = Math.Min(Math.Max(Settings.Default.GPUTextureCacheSize / 1048576, TextureCacheSizeUpDown.Minimum), TextureCacheSizeUpDown.Maximum);
            CollisionCacheSizeUpDown.Value = Math.Min(Math.Max(Settings.Default.GPUBoundCompCacheSize / 1048576, CollisionCacheSizeUpDown.Minimum), CollisionCacheSizeUpDown.Maximum);
        }


        private void AddKeyBinding(string text, Keys key)
        {
            var lvi = KeyBindingsListView.Items.Add(text);
            lvi.SubItems.Add(key.ToString());
            lvi.Tag = key;
        }


        public void SelectTab(string tab)
        {
            switch (tab)
            {
                case "Controls":
                    MainTabControl.SelectedTab = ControlsTabPage;
                    break;
                case "Advanced":
                    MainTabControl.SelectedTab = AdvancedTabPage;
                    break;
            }

        }


        private void UpdateKeyBindingsListViewItem(string item, Keys val)
        {
            foreach (ListViewItem lvi in KeyBindingsListView.Items)
            {
                if (lvi.Text == item)
                {
                    lvi.SubItems[1].Text = val.ToString();
                    lvi.Tag = val;
                    break;
                }
            }
        }


        private void KeyBindingsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = (KeyBindingsListView.SelectedItems.Count == 1) ? KeyBindingsListView.SelectedItems[0] : null;
            if (sel != null)
            {
                selKeyBinding = sel.Text;
                selKeyBindingVal = (Keys)sel.Tag;
                KeyBindingNameLabel.Text = selKeyBinding;
                KeyBindingComboBox.SelectedItem = sel.Tag;
                KeyBindingComboBox.Enabled = true;
                KeyBindButton.Enabled = true;
            }
            else
            {
                selKeyBinding = string.Empty;
                selKeyBindingVal = Keys.None;
                KeyBindingNameLabel.Text = "(未选择绑定)";
                KeyBindingComboBox.SelectedItem = null;
                KeyBindingComboBox.Enabled = false;
                KeyBindButton.Enabled = false;
            }
        }

        private void KeyBindingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selKeyBinding))
            {
                Keys val = (Keys)KeyBindingComboBox.SelectedItem;
                if (val != selKeyBindingVal)
                {
                    selKeyBindingVal = val;
                    keyBindings.SetBinding(selKeyBinding, val);
                    UpdateKeyBindingsListViewItem(selKeyBinding, val);

                    Settings.Default.KeyBindings = keyBindings.GetSetting();
                    if (worldForm != null)
                    {
                        worldForm.SetKeyBindings(keyBindings);
                    }
                }
            }
        }

        private void KeyBindButton_Click(object sender, EventArgs e)
        {
            KeyBindForm f = new KeyBindForm();
            f.SelectedKey = selKeyBindingVal;
            if (f.ShowDialog() == DialogResult.OK)
            {
                var val = f.SelectedKey;
                selKeyBindingVal = val;
                KeyBindingComboBox.SelectedItem = val;
                keyBindings.SetBinding(selKeyBinding, val);
                UpdateKeyBindingsListViewItem(selKeyBinding, val);

                Settings.Default.KeyBindings = keyBindings.GetSetting();
                if (worldForm != null)
                {
                    worldForm.SetKeyBindings(keyBindings);
                }
            }
        }

        private void CameraSensitivityUpDown_ValueChanged(object sender, EventArgs e)
        {
            camSensitivity = (float)CameraSensitivityUpDown.Value * 0.001f;
            Settings.Default.CameraSensitivity = camSensitivity;
            if (worldForm != null)
            {
                worldForm.SetCameraSensitivity(camSensitivity, camSmoothing);
            }
        }

        private void CameraSmoothingUpDown_ValueChanged(object sender, EventArgs e)
        {
            camSmoothing = (float)CameraSmoothingUpDown.Value;
            Settings.Default.CameraSmoothing = camSmoothing;
            if (worldForm != null)
            {
                worldForm.SetCameraSensitivity(camSensitivity, camSmoothing);
            }
        }

        private void MouseInvertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mouseinvert = MouseInvertCheckBox.Checked;
            Settings.Default.MouseInvert = mouseinvert;
            if (worldForm != null)
            {
                worldForm.SetMouseInverted(mouseinvert);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //apply and save the settings.

            Settings.Default.KeyBindings = keyBindings.GetSetting();
            Settings.Default.CameraSensitivity = camSensitivity;
            Settings.Default.CameraSmoothing = camSmoothing;
            Settings.Default.Save();

            DoneButton.Text = "完成";
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要将所有设置恢复为默认吗？", "确认恢复默认设置", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var k = Settings.Default.Key;
                Settings.Default.Reset();
                Settings.Default.Key = k;
                Settings.Default.Save();

                KeyBindingsListView.SelectedItems.Clear();

                keyBindings = new KeyBindings(Settings.Default.KeyBindings);
                LoadKeyBindings();

                camSensitivity = Settings.Default.CameraSensitivity;
                camSmoothing = Settings.Default.CameraSmoothing;
                LoadMouseSettings();


                LoadAdvancedSettings();


                if (worldForm != null)
                {
                    worldForm.SetKeyBindings(keyBindings);
                    worldForm.SetCameraSensitivity(camSensitivity, camSmoothing);
                }

            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (worldForm != null)
            {
                worldForm.OnSettingsFormClosed();
            }
        }

        private void FolderBrowseButton_Click(object sender, EventArgs e)
        {
            GTAFolder.UpdateGTAFolder(false);
            FolderTextBox.Text = GTAFolder.CurrentGTAFolder;
        }

        private void ExcludeFoldersTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.ExcludeFolders = ExcludeFoldersTextBox.Text;
        }

        private void ShadowCascadesUpDown_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.ShadowCascades = (int)ShadowCascadesUpDown.Value;
        }

        private void CacheTimeUpDown_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.CacheTime = (double)CacheTimeUpDown.Value;
        }

        private void CacheSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.CacheSize = (long)CacheSizeUpDown.Value * 1048576;
        }

        private void GPUCacheTimeUpDown_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.GPUCacheTime = (double)GPUCacheTimeUpDown.Value;
        }

        private void GPUFlushTimeUpDown_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.GPUCacheFlushTime = (double)GPUFlushTimeUpDown.Value;
        }

        private void GeometryCacheSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.GPUGeometryCacheSize = (long)GeometryCacheSizeUpDown.Value * 1048576;
        }

        private void TextureCacheSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.GPUTextureCacheSize = (long)TextureCacheSizeUpDown.Value * 1048576;
        }

        private void CollisionCacheSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.GPUBoundCompCacheSize = (long)CollisionCacheSizeUpDown.Value * 1048576;
        }
    }
}
