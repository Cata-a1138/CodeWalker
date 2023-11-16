using CodeWalker.GameFiles;
using CodeWalker.Rendering;
using CodeWalker.Utils;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWalker.World
{
    public partial class WorldInfoForm : Form
    {
        WorldForm WorldForm;
        MapSelection Selection;
        string SelectionMode = "";
        bool MouseSelectEnable = false;
        Texture currentTex; // Used by save button

        public WorldInfoForm(WorldForm worldForm)
        {
            WorldForm = worldForm;
            InitializeComponent();

            //SelectionModeComboBox.SelectedIndex = 0;
        }

        private void MouseSelectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MouseSelectCheckBox.Checked != MouseSelectEnable)
            {
                MouseSelectEnable = MouseSelectCheckBox.Checked;
                WorldForm.OnInfoFormSelectionModeChanged(SelectionMode, MouseSelectEnable);
            }
        }

        private void SelectionModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectionModeComboBox.Text != SelectionMode)
            {
                SelectionMode = SelectionModeComboBox.Text;
                WorldForm.OnInfoFormSelectionModeChanged(SelectionMode, MouseSelectEnable);
            }
        }

        public void SetSelectionMode(string mode, bool enable)
        {
            SelectionMode = mode;
            MouseSelectEnable = enable;
            SelectionModeComboBox.Text = mode;
            MouseSelectCheckBox.Checked = enable;
        }

        public void SetSelection(MapSelection item)
        {
            Selection = item;

            SelectionNameTextBox.Text = item.GetNameString("未选择对象");
            //SelEntityPropertyGrid.SelectedObject = item.EntityDef;
            SelArchetypePropertyGrid.SelectedObject = item.Archetype;
            SelDrawablePropertyGrid.SelectedObject = item.Drawable;
            SelDrawableModelPropertyGrid.SelectedObject = null;
            SelDrawableModelsTreeView.Nodes.Clear();
            SelDrawableTexturesTreeView.Nodes.Clear();
            SelDrawableTexturePropertyGrid.SelectedObject = null;
            SelDrawableTexturePictureBox.Image = null;
            HierarchyTreeView.Nodes.Clear();
            if (item.Drawable != null)
            {
                AddSelectionDrawableModelsTreeNodes(item.Drawable.DrawableModels?.High, "高细节", true);
                AddSelectionDrawableModelsTreeNodes(item.Drawable.DrawableModels?.Med, "中等细节", false);
                AddSelectionDrawableModelsTreeNodes(item.Drawable.DrawableModels?.Low, "低细节", false);
                AddSelectionDrawableModelsTreeNodes(item.Drawable.DrawableModels?.VLow, "极低细节", false);
                //AddSelectionDrawableModelsTreeNodes(item.Drawable.DrawableModels?.Extra, "X Detail", false);
            }

            if (item.EntityDef != null)
            {
                AddSelectionEntityHierarchyNodes(item.EntityDef);
            }

            if (item.MultipleSelectionItems != null)
            {
                SelectionEntityTabPage.Text = "多个对象";
                SelEntityPropertyGrid.SelectedObject = item.MultipleSelectionItems;
            }
            else if (item.TimeCycleModifier != null)
            {
                SelectionEntityTabPage.Text = "Time Cycle 修改器";
                SelEntityPropertyGrid.SelectedObject = item.TimeCycleModifier;
            }
            else if (item.CarGenerator != null)
            {
                SelectionEntityTabPage.Text = "车辆生成器";
                SelEntityPropertyGrid.SelectedObject = item.CarGenerator;
            }
            else if (item.LodLight!= null)
            {
                SelectionEntityTabPage.Text = "远景灯光";
                SelEntityPropertyGrid.SelectedObject = item.LodLight;
            }
            else if (item.GrassBatch != null)
            {
                SelectionEntityTabPage.Text = "实例草";
                SelEntityPropertyGrid.SelectedObject = item.GrassBatch;
            }
            else if (item.BoxOccluder != null)
            {
                SelectionEntityTabPage.Text = "遮挡盒";
                SelEntityPropertyGrid.SelectedObject = item.BoxOccluder;
            }
            else if (item.OccludeModelTri != null)
            {
                SelectionEntityTabPage.Text = "遮挡模型三角";
                SelEntityPropertyGrid.SelectedObject = item.OccludeModelTri;
            }
            else if (item.WaterQuad != null)
            {
                SelectionEntityTabPage.Text = "块状水";
                SelEntityPropertyGrid.SelectedObject = item.WaterQuad;
            }
            else if (item.CalmingQuad != null)
            {
                SelectionEntityTabPage.Text = "静止的块状水";
                SelEntityPropertyGrid.SelectedObject = item.CalmingQuad;
            }
            else if (item.WaveQuad != null)
            {
                SelectionEntityTabPage.Text = "波浪的块状水";
                SelEntityPropertyGrid.SelectedObject = item.WaveQuad;
            }
            else if (item.NavPoly != null)
            {
                SelectionEntityTabPage.Text = "寻路网格";
                SelEntityPropertyGrid.SelectedObject = item.NavPoly;
            }
            else if (item.NavPoint != null)
            {
                SelectionEntityTabPage.Text = "寻路点";
                SelEntityPropertyGrid.SelectedObject = item.NavPoint;
            }
            else if (item.NavPortal != null)
            {
                SelectionEntityTabPage.Text = "寻路门户";
                SelEntityPropertyGrid.SelectedObject = item.NavPortal;
            }
            else if (item.PathNode != null)
            {
                SelectionEntityTabPage.Text = "路线节点";
                SelEntityPropertyGrid.SelectedObject = item.PathNode;
            }
            else if (item.TrainTrackNode != null)
            {
                SelectionEntityTabPage.Text = "火车轨道节点";
                SelEntityPropertyGrid.SelectedObject = item.TrainTrackNode;
            }
            else if (item.ScenarioNode != null)
            {
                SelectionEntityTabPage.Text = item.ScenarioNode.FullTypeName;
                SelEntityPropertyGrid.SelectedObject = item.ScenarioNode;
            }
            else if (item.Audio != null)
            {
                SelectionEntityTabPage.Text = item.Audio.FullTypeName;
                SelEntityPropertyGrid.SelectedObject = item.Audio;
            }
            else
            {
                SelectionEntityTabPage.Text = "实体";
                SelEntityPropertyGrid.SelectedObject = item.EntityDef;
            }


            if (item.EntityExtension != null)
            {
                SelectionExtensionTabPage.Text = "实体扩展";
                SelExtensionPropertyGrid.SelectedObject = item.EntityExtension;
            }
            else if (item.ArchetypeExtension != null)
            {
                SelectionExtensionTabPage.Text = "定义扩展";
                SelExtensionPropertyGrid.SelectedObject = item.ArchetypeExtension;
            }
            else if (item.CollisionVertex != null)
            {
                SelectionExtensionTabPage.Text = "碰撞顶点";
                SelExtensionPropertyGrid.SelectedObject = item.CollisionVertex;
            }
            else if (item.CollisionPoly != null)
            {
                SelectionExtensionTabPage.Text = "碰撞多边形";
                SelExtensionPropertyGrid.SelectedObject = item.CollisionPoly;
            }
            else if (item.CollisionBounds != null)
            {
                SelectionExtensionTabPage.Text = "碰撞边界";
                SelExtensionPropertyGrid.SelectedObject = item.CollisionBounds;
            }
            else
            {
                SelectionExtensionTabPage.Text = "扩展";
                SelExtensionPropertyGrid.SelectedObject = null;
            }

        }
        private void AddSelectionDrawableModelsTreeNodes(DrawableModel[] models, string prefix, bool check)
        {
            if (models == null) return;

            for (int mi = 0; mi < models.Length; mi++)
            {
                var model = models[mi];
                string mprefix = prefix + " " + (mi + 1).ToString();
                var mnode = SelDrawableModelsTreeView.Nodes.Add(mprefix + " " + model.ToString());
                mnode.Tag = model;
                mnode.Checked = check;

                var tmnode = SelDrawableTexturesTreeView.Nodes.Add(mprefix + " " + model.ToString());
                tmnode.Tag = model;

                if (model.Geometries == null) continue;

                foreach (var geom in model.Geometries)
                {
                    var gname = geom.ToString();
                    var gnode = mnode.Nodes.Add(gname);
                    gnode.Tag = geom;
                    gnode.Checked = true;// check;

                    var tgnode = tmnode.Nodes.Add(gname);
                    tgnode.Tag = geom;

                    if ((geom.Shader != null) && (geom.Shader.ParametersList != null) && (geom.Shader.ParametersList.Hashes != null))
                    {
                        var pl = geom.Shader.ParametersList;
                        var h = pl.Hashes;
                        var p = pl.Parameters;
                        for (int ip = 0; ip < h.Length; ip++)
                        {
                            var hash = pl.Hashes[ip];
                            var parm = pl.Parameters[ip];
                            var tex = parm.Data as TextureBase;
                            if (tex != null)
                            {
                                var t = tex as Texture;
                                var tstr = tex.Name.Trim();
                                if (t != null)
                                {
                                    tstr = string.Format("{0} ({1}x{2}, 嵌入)", tex.Name, t.Width, t.Height);
                                }
                                var tnode = tgnode.Nodes.Add(hash.ToString().Trim() + ": " + tstr);
                                tnode.Tag = tex;
                            }
                        }
                        tgnode.Expand();
                    }

                }

                mnode.Expand();
                tmnode.Expand();
            }
        }

        private void AddSelectionEntityHierarchyNodes(YmapEntityDef entity)
        {
            if (entity == null) return;

            var e = entity;
            TreeNode tn = null;
            TreeNode seltn = null;

            while (e != null)
            {
                var newtn = new TreeNode(e.Name);
                newtn.Tag = e;
                if (tn != null)
                {
                    newtn.Nodes.Add(tn);
                }
                else
                {
                    seltn = newtn;
                }
                if (e.Children != null)
                {
                    foreach (var c in e.Children)
                    {
                        if ((tn != null) && (c == tn.Tag)) continue;
                        var ctn = new TreeNode(c.Name);
                        ctn.Tag = c;
                        newtn.Nodes.Add(ctn);
                    }
                }

                tn = newtn;
                e = e.Parent;
            }

            if (tn != null)
            {
                HierarchyTreeView.Nodes.Add(tn);
                tn.ExpandAll();
            }
            if (seltn != null)
            {
                HierarchyTreeView.SelectedNode = seltn;
            }

        }


        private void DisplayTexture(Texture tex, int mip)
        {
            try
            {
                int cmip = Math.Min(Math.Max(mip, 0), tex.Levels - 1);
                byte[] pixels = DDSIO.GetPixels(tex, cmip);
                int w = tex.Width >> cmip;
                int h = tex.Height >> cmip;
                Bitmap bmp = new Bitmap(w, h, PixelFormat.Format32bppArgb);

                if (pixels != null)
                {
                    var BoundsRect = new System.Drawing.Rectangle(0, 0, w, h);
                    BitmapData bmpData = bmp.LockBits(BoundsRect, ImageLockMode.WriteOnly, bmp.PixelFormat);
                    IntPtr ptr = bmpData.Scan0;
                    int bytes = bmpData.Stride * bmp.Height;
                    Marshal.Copy(pixels, 0, ptr, bytes);
                    bmp.UnlockBits(bmpData);
                }

                SelDrawableTexturePictureBox.Image = bmp;
                SelTextureDimensionsLabel.Text = w.ToString() + " x " + h.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法读取纹理 mip：\n" + ex.ToString());
                SelDrawableTexturePictureBox.Image = null;
            }
        }

        private void SelectTexture(TextureBase texbase, bool mipchange)
        {
            Texture tex = texbase as Texture;
            YtdFile ytd = null;
            string errstr = string.Empty;
            if ((tex == null) && (texbase != null))
            {
                tex = TryGetTexture(texbase, out ytd, ref errstr);
            }
            if (tex != null)
            {
                currentTex = tex;
                int mip = 0;
                if (mipchange)
                {
                    mip = SelTextureMipTrackBar.Value;
                    if (mip >= tex.Levels) mip = tex.Levels - 1;
                }
                else
                {
                    SelTextureMipTrackBar.Maximum = tex.Levels - 1;
                }
                DisplayTexture(tex, mip);


                //try get owner drawable to get the name for the dictionary textbox...
                object owner = null;
                if (Selection.Drawable != null)
                {
                    owner = Selection.Drawable.Owner;
                }
                YdrFile ydr = owner as YdrFile;
                YddFile ydd = owner as YddFile;
                YftFile yft = owner as YftFile;

                SelTextureNameTextBox.Text = tex.Name;
                SelTextureDictionaryTextBox.Text = (ytd != null) ? ytd.Name : (ydr != null) ? ydr.Name : (ydd != null) ? ydd.Name : (yft != null) ? yft.Name : string.Empty;
                SaveTextureButton.Enabled = true;
            }
            else
            {
                SelDrawableTexturePictureBox.Image = null;
                SelTextureNameTextBox.Text = errstr;
                SelTextureDictionaryTextBox.Text = string.Empty;
                SelTextureMipTrackBar.Value = 0;
                SelTextureMipTrackBar.Maximum = 0;
                SelTextureDimensionsLabel.Text = "-";
                SaveTextureButton.Enabled = false;
                currentTex = null;
            }
        }

        private Texture TryGetTexture(TextureBase texbase, out YtdFile ytd, ref string errstr)
        {
            //need to load from txd.
            var arch = Selection.Archetype;
            uint texhash = texbase.NameHash;
            uint txdHash = (arch != null) ? arch.TextureDict.Hash : 0;
            var tex = TryGetTextureFromYtd(texhash, txdHash, out ytd);
            if (tex == null)
            { //search parent ytds...
                uint ptxdhash = WorldForm.GameFileCache.TryGetParentYtdHash(txdHash);
                while ((ptxdhash != 0) && (tex == null))
                {
                    tex = TryGetTextureFromYtd(texhash, ptxdhash, out ytd);
                    if (tex == null)
                    {
                        ptxdhash = WorldForm.GameFileCache.TryGetParentYtdHash(ptxdhash);
                    }
                    else
                    { }
                }
                if (tex == null)
                {
                    ytd = WorldForm.GameFileCache.TryGetTextureDictForTexture(texhash);
                    if (ytd != null)
                    {
                        int tries = 0;
                        while (!ytd.Loaded && (tries < 500)) //wait upto ~5 sec
                        {
                            System.Threading.Thread.Sleep(10);
                            tries++;
                        }
                        if (ytd.Loaded)
                        {
                            tex = ytd.TextureDict.Lookup(texhash);
                        }
                    }
                    if (tex == null)
                    {
                        ytd = null;
                        errstr = "<无法找到纹理！>";
                    }
                }
            }
            return tex;
        }

        private Texture TryGetTextureFromYtd(uint texHash, uint txdHash, out YtdFile ytd)
        {
            if (txdHash != 0)
            {
                ytd = WorldForm.GameFileCache.GetYtd(txdHash);
                if (ytd != null)
                {
                    int tries = 0;
                    while (!ytd.Loaded && (tries < 500)) //wait upto ~5 sec
                    {
                        System.Threading.Thread.Sleep(10);
                        tries++;
                    }
                    if (ytd.Loaded)
                    {
                        return ytd.TextureDict.Lookup(texHash);
                    }
                }
            }
            ytd = null;
            return null;
        }


        private void WorldInfoForm_Load(object sender, EventArgs e)
        {
            SetSelection(Selection);
        }

        private void WorldInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WorldForm.OnInfoFormClosed();
        }

        public void SyncSelDrawableModelsTreeNode(TreeNode node)
        {
            //called by the world form when a selection treeview node is checked/unchecked.
            foreach (TreeNode mnode in SelDrawableModelsTreeView.Nodes)
            {
                if (mnode.Tag == node.Tag)
                {
                    if (mnode.Checked != node.Checked)
                    {
                        mnode.Checked = node.Checked;
                    }
                }
                foreach (TreeNode gnode in mnode.Nodes)
                {
                    if (gnode.Tag == node.Tag)
                    {
                        if (gnode.Checked != node.Checked)
                        {
                            gnode.Checked = node.Checked;
                        }
                    }
                }
            }
        }

        private void SelDrawableModelsTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            WorldForm.SyncSelDrawableModelsTreeNode(e.Node);
        }

        private void SelDrawableModelsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelDrawableModelPropertyGrid.SelectedObject = e.Node?.Tag;
        }

        private void SelDrawableTexturesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelDrawableTexturePropertyGrid.SelectedObject = e.Node?.Tag;

            TextureBase texbase = e.Node?.Tag as TextureBase;

            SelTextureMipTrackBar.Value = 0;
            SelTextureMipLabel.Text = "0";

            SelectTexture(texbase, false);
        }

        private void SelTextureMipTrackBar_Scroll(object sender, EventArgs e)
        {
            var node = SelDrawableTexturesTreeView.SelectedNode;

            TextureBase texbase = node?.Tag as TextureBase;

            SelTextureMipLabel.Text = SelTextureMipTrackBar.Value.ToString();

            SelectTexture(texbase, true);
        }

        private void HierarchyTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var sele = HierarchyTreeView.SelectedNode?.Tag as YmapEntityDef;
            HierarchyPropertyGrid.SelectedObject = sele;
        }

        private void SaveAllTexturesButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialogNew() != DialogResult.OK) return;
            string folderpath = FolderBrowserDialog.SelectedPath;
            if (!folderpath.EndsWith("\\")) folderpath += "\\";

            var texs = new List<Texture>();
            foreach (TreeNode modelnode in SelDrawableTexturesTreeView.Nodes)
            {
                foreach (TreeNode geomnode in modelnode.Nodes)
                {
                    foreach (TreeNode texnode in geomnode.Nodes)
                    {
                        var texbase = texnode.Tag as TextureBase;
                        var tex = texbase as Texture;
                        string errstr = "";
                        if ((tex == null) && (texbase != null))
                        {
                            tex = TryGetTexture(texbase, out _, ref errstr);
                        }
                        if (tex != null)
                        {
                            if (!texs.Contains(tex))
                            {
                                texs.Add(tex);
                            }
                        }
                    }
                }
            }

            foreach (var tex in texs)
            {
                string fpath = folderpath + tex.Name + ".dds";
                byte[] dds = DDSIO.GetDDSFile(tex);
                File.WriteAllBytes(fpath, dds);
            }

        }

        private void SaveTextureButton_Click(object sender, EventArgs e)
        {
            if (currentTex == null) return;
            string fname = currentTex.Name + ".dds";
            SaveFileDialog.FileName = fname;
            if (SaveFileDialog.ShowDialog() != DialogResult.OK) return;
            string fpath = SaveFileDialog.FileName;
            byte[] dds = DDSIO.GetDDSFile(currentTex);
            File.WriteAllBytes(fpath, dds);
        }
    }
}
