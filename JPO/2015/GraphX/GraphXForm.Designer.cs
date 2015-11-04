namespace GraphX
{
    partial class GraphXForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphXForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.horizontalScrollBar = new System.Windows.Forms.HScrollBar();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.labelBoxColor = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSizeHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSizeWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLocationY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLocationX = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelPropertiesTitleBackground = new System.Windows.Forms.Panel();
            this.labelPropertiesTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.backPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.separatorPanel.SuspendLayout();
            this.propertiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLocationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLocationX)).BeginInit();
            this.panelPropertiesTitleBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.mainPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.propertiesPanel);
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 498);
            this.mainSplitContainer.SplitterDistance = 555;
            this.mainSplitContainer.SplitterWidth = 2;
            this.mainSplitContainer.TabIndex = 0;
            this.mainSplitContainer.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.separatorPanel);
            this.mainPanel.Controls.Add(this.horizontalScrollBar);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(555, 498);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // separatorPanel
            // 
            this.separatorPanel.BackColor = System.Drawing.Color.Transparent;
            this.separatorPanel.CausesValidation = false;
            this.separatorPanel.Controls.Add(this.buttonCollapse);
            this.separatorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.separatorPanel.Location = new System.Drawing.Point(528, 0);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(27, 481);
            this.separatorPanel.TabIndex = 0;
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.CausesValidation = false;
            this.buttonCollapse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCollapse.Image = global::GraphX.Properties.Resources.tinyrightarrow;
            this.buttonCollapse.Location = new System.Drawing.Point(0, 0);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(27, 29);
            this.buttonCollapse.TabIndex = 0;
            this.buttonCollapse.UseVisualStyleBackColor = true;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // horizontalScrollBar
            // 
            this.horizontalScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalScrollBar.LargeChange = 20;
            this.horizontalScrollBar.Location = new System.Drawing.Point(0, 481);
            this.horizontalScrollBar.Name = "horizontalScrollBar";
            this.horizontalScrollBar.Size = new System.Drawing.Size(555, 17);
            this.horizontalScrollBar.TabIndex = 1;
            this.horizontalScrollBar.Visible = false;
            this.horizontalScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.horizontalScrollBar_Scroll);
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.propertiesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.propertiesPanel.Controls.Add(this.labelBoxColor);
            this.propertiesPanel.Controls.Add(this.labelColor);
            this.propertiesPanel.Controls.Add(this.labelWidth);
            this.propertiesPanel.Controls.Add(this.labelSize);
            this.propertiesPanel.Controls.Add(this.labelLocation);
            this.propertiesPanel.Controls.Add(this.labelName);
            this.propertiesPanel.Controls.Add(this.numericUpDownWidth);
            this.propertiesPanel.Controls.Add(this.numericUpDownSizeHeight);
            this.propertiesPanel.Controls.Add(this.numericUpDownSizeWidth);
            this.propertiesPanel.Controls.Add(this.numericUpDownLocationY);
            this.propertiesPanel.Controls.Add(this.numericUpDownLocationX);
            this.propertiesPanel.Controls.Add(this.textBoxName);
            this.propertiesPanel.Controls.Add(this.panelPropertiesTitleBackground);
            this.propertiesPanel.Controls.Add(this.pictureBoxLogo);
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesPanel.Location = new System.Drawing.Point(0, 0);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Size = new System.Drawing.Size(227, 498);
            this.propertiesPanel.TabIndex = 0;
            // 
            // labelBoxColor
            // 
            this.labelBoxColor.BackColor = System.Drawing.Color.Black;
            this.labelBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoxColor.Location = new System.Drawing.Point(88, 180);
            this.labelBoxColor.Name = "labelBoxColor";
            this.labelBoxColor.Size = new System.Drawing.Size(120, 20);
            this.labelBoxColor.TabIndex = 14;
            this.labelBoxColor.Click += new System.EventHandler(this.labelBoxColor_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(18, 179);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(54, 16);
            this.labelColor.TabIndex = 13;
            this.labelColor.Text = "Couleur";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(18, 151);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(64, 16);
            this.labelWidth.TabIndex = 12;
            this.labelWidth.Text = "Epaisseur";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(20, 123);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(40, 16);
            this.labelSize.TabIndex = 11;
            this.labelSize.Text = "Taille";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(20, 95);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(56, 16);
            this.labelLocation.TabIndex = 10;
            this.labelLocation.Text = "Position";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(20, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 16);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Nom";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(88, 151);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownWidth.TabIndex = 7;
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // numericUpDownSizeHeight
            // 
            this.numericUpDownSizeHeight.Location = new System.Drawing.Point(148, 123);
            this.numericUpDownSizeHeight.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDownSizeHeight.Name = "numericUpDownSizeHeight";
            this.numericUpDownSizeHeight.Size = new System.Drawing.Size(57, 21);
            this.numericUpDownSizeHeight.TabIndex = 6;
            this.numericUpDownSizeHeight.ValueChanged += new System.EventHandler(this.numericUpDownSizeHeight_ValueChanged);
            // 
            // numericUpDownSizeWidth
            // 
            this.numericUpDownSizeWidth.Location = new System.Drawing.Point(88, 123);
            this.numericUpDownSizeWidth.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDownSizeWidth.Name = "numericUpDownSizeWidth";
            this.numericUpDownSizeWidth.Size = new System.Drawing.Size(57, 21);
            this.numericUpDownSizeWidth.TabIndex = 5;
            this.numericUpDownSizeWidth.ValueChanged += new System.EventHandler(this.numericUpDownSizeWidth_ValueChanged);
            // 
            // numericUpDownLocationY
            // 
            this.numericUpDownLocationY.Location = new System.Drawing.Point(148, 95);
            this.numericUpDownLocationY.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDownLocationY.Name = "numericUpDownLocationY";
            this.numericUpDownLocationY.Size = new System.Drawing.Size(57, 21);
            this.numericUpDownLocationY.TabIndex = 4;
            this.numericUpDownLocationY.ValueChanged += new System.EventHandler(this.numericUpDownLocationY_ValueChanged);
            // 
            // numericUpDownLocationX
            // 
            this.numericUpDownLocationX.Location = new System.Drawing.Point(88, 95);
            this.numericUpDownLocationX.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDownLocationX.Name = "numericUpDownLocationX";
            this.numericUpDownLocationX.Size = new System.Drawing.Size(57, 21);
            this.numericUpDownLocationX.TabIndex = 3;
            this.numericUpDownLocationX.ValueChanged += new System.EventHandler(this.numericUpDownLocationX_ValueChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(88, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 21);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // panelPropertiesTitleBackground
            // 
            this.panelPropertiesTitleBackground.BackgroundImage = global::GraphX.Properties.Resources.menuBarTileLight;
            this.panelPropertiesTitleBackground.Controls.Add(this.labelPropertiesTitle);
            this.panelPropertiesTitleBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPropertiesTitleBackground.Location = new System.Drawing.Point(0, 0);
            this.panelPropertiesTitleBackground.Name = "panelPropertiesTitleBackground";
            this.panelPropertiesTitleBackground.Size = new System.Drawing.Size(227, 28);
            this.panelPropertiesTitleBackground.TabIndex = 2;
            // 
            // labelPropertiesTitle
            // 
            this.labelPropertiesTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelPropertiesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPropertiesTitle.Font = new System.Drawing.Font("Oxygen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPropertiesTitle.Location = new System.Drawing.Point(0, 0);
            this.labelPropertiesTitle.Name = "labelPropertiesTitle";
            this.labelPropertiesTitle.Size = new System.Drawing.Size(227, 26);
            this.labelPropertiesTitle.TabIndex = 1;
            this.labelPropertiesTitle.Text = "Propriétés";
            this.labelPropertiesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 347);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(227, 151);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.Transparent;
            this.backPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPanel.Controls.Add(this.mainSplitContainer);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(784, 498);
            this.backPanel.TabIndex = 14;
            // 
            // GraphXForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 498);
            this.Controls.Add(this.backPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Oxygen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphXForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphX";
            this.SizeChanged += new System.EventHandler(this.GraphXForm_SizeChanged);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.separatorPanel.ResumeLayout(false);
            this.propertiesPanel.ResumeLayout(false);
            this.propertiesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLocationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLocationX)).EndInit();
            this.panelPropertiesTitleBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel propertiesPanel;
        private System.Windows.Forms.Panel separatorPanel;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.HScrollBar horizontalScrollBar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelPropertiesTitleBackground;
        private System.Windows.Forms.Label labelPropertiesTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownLocationY;
        private System.Windows.Forms.NumericUpDown numericUpDownLocationX;
        private System.Windows.Forms.NumericUpDown numericUpDownSizeHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSizeWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label labelBoxColor;
    }
}

