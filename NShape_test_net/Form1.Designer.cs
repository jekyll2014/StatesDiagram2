
namespace StatesDiagram2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox_useVsCode = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_useShelf = new System.Windows.Forms.CheckBox();
            this.textBox_tag = new System.Windows.Forms.TextBox();
            this.button_loadStates = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBox_layoutMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_showStateElements = new System.Windows.Forms.CheckBox();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.SuspendLayout();
            // 
            // checkBox_useVsCode
            // 
            this.checkBox_useVsCode.AutoSize = true;
            this.checkBox_useVsCode.Location = new System.Drawing.Point(12, 87);
            this.checkBox_useVsCode.Name = "checkBox_useVsCode";
            this.checkBox_useVsCode.Size = new System.Drawing.Size(87, 17);
            this.checkBox_useVsCode.TabIndex = 18;
            this.checkBox_useVsCode.Text = "Use VSCode";
            this.checkBox_useVsCode.UseVisualStyleBackColor = true;
            this.checkBox_useVsCode.CheckedChanged += new System.EventHandler(this.CheckBox_UseVsCode_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 612);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Element notes:";
            // 
            // checkBox_useShelf
            // 
            this.checkBox_useShelf.AutoSize = true;
            this.checkBox_useShelf.Checked = true;
            this.checkBox_useShelf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_useShelf.Location = new System.Drawing.Point(12, 41);
            this.checkBox_useShelf.Name = "checkBox_useShelf";
            this.checkBox_useShelf.Size = new System.Drawing.Size(82, 17);
            this.checkBox_useShelf.TabIndex = 16;
            this.checkBox_useShelf.Text = "SHELF json";
            this.checkBox_useShelf.UseVisualStyleBackColor = true;
            this.checkBox_useShelf.CheckedChanged += new System.EventHandler(this.CheckBox_UseShelf_CheckedChanged);
            // 
            // textBox_tag
            // 
            this.textBox_tag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_tag.Location = new System.Drawing.Point(12, 628);
            this.textBox_tag.Multiline = true;
            this.textBox_tag.Name = "textBox_tag";
            this.textBox_tag.ReadOnly = true;
            this.textBox_tag.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_tag.Size = new System.Drawing.Size(1246, 67);
            this.textBox_tag.TabIndex = 15;
            // 
            // button_loadStates
            // 
            this.button_loadStates.Location = new System.Drawing.Point(12, 12);
            this.button_loadStates.Name = "button_loadStates";
            this.button_loadStates.Size = new System.Drawing.Size(121, 23);
            this.button_loadStates.TabIndex = 12;
            this.button_loadStates.Text = "Load states";
            this.button_loadStates.UseVisualStyleBackColor = true;
            this.button_loadStates.Click += new System.EventHandler(this.Button_LoadStates_Click);
            // 
            // comboBox_layoutMode
            // 
            this.comboBox_layoutMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_layoutMode.FormattingEnabled = true;
            this.comboBox_layoutMode.Location = new System.Drawing.Point(12, 123);
            this.comboBox_layoutMode.Name = "comboBox_layoutMode";
            this.comboBox_layoutMode.Size = new System.Drawing.Size(121, 21);
            this.comboBox_layoutMode.TabIndex = 20;
            this.comboBox_layoutMode.SelectedIndexChanged += new System.EventHandler(this.ComboBox_layoutMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Layout mode";
            // 
            // checkBox_showStateElements
            // 
            this.checkBox_showStateElements.AutoSize = true;
            this.checkBox_showStateElements.Checked = true;
            this.checkBox_showStateElements.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showStateElements.Location = new System.Drawing.Point(12, 64);
            this.checkBox_showStateElements.Name = "checkBox_showStateElements";
            this.checkBox_showStateElements.Size = new System.Drawing.Size(124, 17);
            this.checkBox_showStateElements.TabIndex = 16;
            this.checkBox_showStateElements.Text = "Show state elements";
            this.checkBox_showStateElements.UseVisualStyleBackColor = true;
            this.checkBox_showStateElements.CheckedChanged += new System.EventHandler(this.CheckBox_showStateElements_CheckedChanged);
            // 
            // gViewer1
            // 
            this.gViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.IncrementalDraggingModeAlways = false;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = false;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(139, 12);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = false;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(1119, 610);
            this.gViewer1.TabIndex = 0;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            this.gViewer1.ObjectUnderMouseCursorChanged += new System.EventHandler<Microsoft.Msagl.Drawing.ObjectUnderMouseCursorChangedEventArgs>(this.GViewer1_ObjectUnderMouseCursorChanged);
            this.gViewer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GViewer1_MouseMove);
            this.gViewer1.DoubleClick += new System.EventHandler(this.GViewer1_DoubleClick);
            this.gViewer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GViewer1_MouseClick);
            this.gViewer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GViewer1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 707);
            this.Controls.Add(this.comboBox_layoutMode);
            this.Controls.Add(this.gViewer1);
            this.Controls.Add(this.checkBox_useVsCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_showStateElements);
            this.Controls.Add(this.checkBox_useShelf);
            this.Controls.Add(this.textBox_tag);
            this.Controls.Add(this.button_loadStates);
            this.Name = "Form1";
            this.Text = "StatesDiagram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_RefreshLayout;
        private System.Windows.Forms.Button button_loadStates;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox_tag;
        private System.Windows.Forms.CheckBox checkBox_useShelf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_useVsCode;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_layoutMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_showStateElements;
    }
}

