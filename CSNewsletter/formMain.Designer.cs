namespace CSNewsletter
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            this.planelSplit = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.listboxArticles = new System.Windows.Forms.ListBox();
            this.labelArticles = new System.Windows.Forms.Label();
            this.comboboxNewsletter = new System.Windows.Forms.ComboBox();
            this.labelNewsletter = new System.Windows.Forms.Label();
            this.panelArticlesButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonArticleAdd = new System.Windows.Forms.Button();
            this.buttonArticleEdit = new System.Windows.Forms.Button();
            this.buttonArticleDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonImageName = new System.Windows.Forms.Button();
            this.updownOrder = new System.Windows.Forms.NumericUpDown();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelPhotoGalleryID = new System.Windows.Forms.Label();
            this.textboxPhotoGalleryID = new System.Windows.Forms.TextBox();
            this.checkboxPhotoGalleryUse = new System.Windows.Forms.CheckBox();
            this.labelPhotoGalleryUse = new System.Windows.Forms.Label();
            this.textboxBody = new System.Windows.Forms.TextBox();
            this.labelBody = new System.Windows.Forms.Label();
            this.textboxImageName = new System.Windows.Forms.TextBox();
            this.labelImageName = new System.Windows.Forms.Label();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textboxArticleID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.tooltipMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.planelSplit)).BeginInit();
            this.planelSplit.Panel1.SuspendLayout();
            this.planelSplit.Panel2.SuspendLayout();
            this.planelSplit.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelArticlesButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // planelSplit
            // 
            this.planelSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planelSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planelSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.planelSplit.Location = new System.Drawing.Point(0, 0);
            this.planelSplit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.planelSplit.Name = "planelSplit";
            // 
            // planelSplit.Panel1
            // 
            this.planelSplit.Panel1.Controls.Add(this.panelLeft);
            // 
            // planelSplit.Panel2
            // 
            this.planelSplit.Panel2.Controls.Add(this.buttonCancel);
            this.planelSplit.Panel2.Controls.Add(this.buttonOk);
            this.planelSplit.Panel2.Controls.Add(this.buttonImageName);
            this.planelSplit.Panel2.Controls.Add(this.updownOrder);
            this.planelSplit.Panel2.Controls.Add(this.labelOrder);
            this.planelSplit.Panel2.Controls.Add(this.labelPhotoGalleryID);
            this.planelSplit.Panel2.Controls.Add(this.textboxPhotoGalleryID);
            this.planelSplit.Panel2.Controls.Add(this.checkboxPhotoGalleryUse);
            this.planelSplit.Panel2.Controls.Add(this.labelPhotoGalleryUse);
            this.planelSplit.Panel2.Controls.Add(this.textboxBody);
            this.planelSplit.Panel2.Controls.Add(this.labelBody);
            this.planelSplit.Panel2.Controls.Add(this.textboxImageName);
            this.planelSplit.Panel2.Controls.Add(this.labelImageName);
            this.planelSplit.Panel2.Controls.Add(this.textboxTitle);
            this.planelSplit.Panel2.Controls.Add(this.labelTitulo);
            this.planelSplit.Panel2.Controls.Add(this.textboxArticleID);
            this.planelSplit.Panel2.Controls.Add(this.labelID);
            this.planelSplit.Size = new System.Drawing.Size(983, 450);
            this.planelSplit.SplitterDistance = 266;
            this.planelSplit.SplitterWidth = 8;
            this.planelSplit.TabIndex = 4;
            // 
            // panelLeft
            // 
            this.panelLeft.ColumnCount = 1;
            this.panelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLeft.Controls.Add(this.listboxArticles, 0, 3);
            this.panelLeft.Controls.Add(this.labelArticles, 0, 2);
            this.panelLeft.Controls.Add(this.comboboxNewsletter, 0, 1);
            this.panelLeft.Controls.Add(this.labelNewsletter, 0, 0);
            this.panelLeft.Controls.Add(this.panelArticlesButtons, 0, 4);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.RowCount = 5;
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLeft.Size = new System.Drawing.Size(264, 448);
            this.panelLeft.TabIndex = 0;
            // 
            // listboxArticles
            // 
            this.listboxArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxArticles.FormattingEnabled = true;
            this.listboxArticles.ItemHeight = 16;
            this.listboxArticles.Location = new System.Drawing.Point(3, 84);
            this.listboxArticles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxArticles.Name = "listboxArticles";
            this.listboxArticles.Size = new System.Drawing.Size(258, 286);
            this.listboxArticles.TabIndex = 3;
            this.listboxArticles.SelectedIndexChanged += new System.EventHandler(this.ArticlesSelectionChange);
            // 
            // labelArticles
            // 
            this.labelArticles.AutoSize = true;
            this.labelArticles.Location = new System.Drawing.Point(5, 60);
            this.labelArticles.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelArticles.Name = "labelArticles";
            this.labelArticles.Size = new System.Drawing.Size(66, 17);
            this.labelArticles.TabIndex = 2;
            this.labelArticles.Text = "Artículos:";
            // 
            // comboboxNewsletter
            // 
            this.comboboxNewsletter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxNewsletter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNewsletter.FormattingEnabled = true;
            this.comboboxNewsletter.Location = new System.Drawing.Point(3, 29);
            this.comboboxNewsletter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboboxNewsletter.Name = "comboboxNewsletter";
            this.comboboxNewsletter.Size = new System.Drawing.Size(258, 24);
            this.comboboxNewsletter.TabIndex = 1;
            this.comboboxNewsletter.SelectedIndexChanged += new System.EventHandler(this.NewsletterChange);
            // 
            // labelNewsletter
            // 
            this.labelNewsletter.AutoSize = true;
            this.labelNewsletter.Location = new System.Drawing.Point(5, 5);
            this.labelNewsletter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelNewsletter.Name = "labelNewsletter";
            this.labelNewsletter.Size = new System.Drawing.Size(78, 17);
            this.labelNewsletter.TabIndex = 0;
            this.labelNewsletter.Text = "Newsletter:";
            // 
            // panelArticlesButtons
            // 
            this.panelArticlesButtons.AutoSize = true;
            this.panelArticlesButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelArticlesButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArticlesButtons.Controls.Add(this.buttonArticleAdd);
            this.panelArticlesButtons.Controls.Add(this.buttonArticleEdit);
            this.panelArticlesButtons.Controls.Add(this.buttonArticleDelete);
            this.panelArticlesButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArticlesButtons.Location = new System.Drawing.Point(3, 374);
            this.panelArticlesButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelArticlesButtons.Name = "panelArticlesButtons";
            this.panelArticlesButtons.Size = new System.Drawing.Size(258, 72);
            this.panelArticlesButtons.TabIndex = 4;
            // 
            // buttonArticleAdd
            // 
            this.buttonArticleAdd.AutoSize = true;
            this.buttonArticleAdd.Image = global::CSNewsletter.Properties.Resources.ADD;
            this.buttonArticleAdd.Location = new System.Drawing.Point(3, 2);
            this.buttonArticleAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonArticleAdd.Name = "buttonArticleAdd";
            this.buttonArticleAdd.Size = new System.Drawing.Size(72, 66);
            this.buttonArticleAdd.TabIndex = 0;
            this.tooltipMain.SetToolTip(this.buttonArticleAdd, "Agregar artículo");
            this.buttonArticleAdd.UseVisualStyleBackColor = true;
            this.buttonArticleAdd.Click += new System.EventHandler(this.ArticleAdd);
            // 
            // buttonArticleEdit
            // 
            this.buttonArticleEdit.AutoSize = true;
            this.buttonArticleEdit.Image = global::CSNewsletter.Properties.Resources.EDIT;
            this.buttonArticleEdit.Location = new System.Drawing.Point(81, 2);
            this.buttonArticleEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonArticleEdit.Name = "buttonArticleEdit";
            this.buttonArticleEdit.Size = new System.Drawing.Size(72, 66);
            this.buttonArticleEdit.TabIndex = 1;
            this.tooltipMain.SetToolTip(this.buttonArticleEdit, "Editar artículo");
            this.buttonArticleEdit.UseVisualStyleBackColor = true;
            this.buttonArticleEdit.Click += new System.EventHandler(this.ArticleEdit);
            // 
            // buttonArticleDelete
            // 
            this.buttonArticleDelete.AutoSize = true;
            this.buttonArticleDelete.Image = global::CSNewsletter.Properties.Resources.DELETE;
            this.buttonArticleDelete.Location = new System.Drawing.Point(159, 2);
            this.buttonArticleDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonArticleDelete.Name = "buttonArticleDelete";
            this.buttonArticleDelete.Size = new System.Drawing.Size(72, 66);
            this.buttonArticleDelete.TabIndex = 2;
            this.tooltipMain.SetToolTip(this.buttonArticleDelete, "Eliminar artículo");
            this.buttonArticleDelete.UseVisualStyleBackColor = true;
            this.buttonArticleDelete.Click += new System.EventHandler(this.ArticleDelete);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Image = global::CSNewsletter.Properties.Resources.CANCEL;
            this.buttonCancel.Location = new System.Drawing.Point(625, 377);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(72, 66);
            this.buttonCancel.TabIndex = 16;
            this.tooltipMain.SetToolTip(this.buttonCancel, "Agregar artículo");
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.AutoSize = true;
            this.buttonOk.Image = global::CSNewsletter.Properties.Resources.OK;
            this.buttonOk.Location = new System.Drawing.Point(5, 377);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(72, 66);
            this.buttonOk.TabIndex = 15;
            this.tooltipMain.SetToolTip(this.buttonOk, "Agregar artículo");
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonImageName
            // 
            this.buttonImageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImageName.Location = new System.Drawing.Point(657, 63);
            this.buttonImageName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImageName.Name = "buttonImageName";
            this.buttonImageName.Size = new System.Drawing.Size(29, 25);
            this.buttonImageName.TabIndex = 6;
            this.buttonImageName.Text = "...";
            this.tooltipMain.SetToolTip(this.buttonImageName, "Examinar...");
            this.buttonImageName.UseVisualStyleBackColor = true;
            // 
            // updownOrder
            // 
            this.updownOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updownOrder.Location = new System.Drawing.Point(68, 327);
            this.updownOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updownOrder.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updownOrder.Name = "updownOrder";
            this.updownOrder.Size = new System.Drawing.Size(76, 22);
            this.updownOrder.TabIndex = 14;
            this.updownOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelOrder
            // 
            this.labelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(3, 330);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(52, 17);
            this.labelOrder.TabIndex = 13;
            this.labelOrder.Text = "Orden:";
            // 
            // labelPhotoGalleryID
            // 
            this.labelPhotoGalleryID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPhotoGalleryID.AutoSize = true;
            this.labelPhotoGalleryID.Location = new System.Drawing.Point(172, 298);
            this.labelPhotoGalleryID.Name = "labelPhotoGalleryID";
            this.labelPhotoGalleryID.Size = new System.Drawing.Size(25, 17);
            this.labelPhotoGalleryID.TabIndex = 11;
            this.labelPhotoGalleryID.Text = "ID:";
            // 
            // textboxPhotoGalleryID
            // 
            this.textboxPhotoGalleryID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxPhotoGalleryID.Location = new System.Drawing.Point(205, 294);
            this.textboxPhotoGalleryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxPhotoGalleryID.MaxLength = 100;
            this.textboxPhotoGalleryID.Name = "textboxPhotoGalleryID";
            this.textboxPhotoGalleryID.Size = new System.Drawing.Size(284, 22);
            this.textboxPhotoGalleryID.TabIndex = 12;
            this.tooltipMain.SetToolTip(this.textboxPhotoGalleryID, "Ingrese un texto para identificar el artículo. Este texto es de uso interno y no " +
        "se muestra en la Newsletter.\r\nEjemplo: \"diafamilia\".");
            this.textboxPhotoGalleryID.Enter += new System.EventHandler(this.TextboxsGotFocus);
            // 
            // checkboxPhotoGalleryUse
            // 
            this.checkboxPhotoGalleryUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxPhotoGalleryUse.AutoSize = true;
            this.checkboxPhotoGalleryUse.Location = new System.Drawing.Point(124, 298);
            this.checkboxPhotoGalleryUse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkboxPhotoGalleryUse.Name = "checkboxPhotoGalleryUse";
            this.checkboxPhotoGalleryUse.Size = new System.Drawing.Size(18, 17);
            this.checkboxPhotoGalleryUse.TabIndex = 10;
            this.checkboxPhotoGalleryUse.UseVisualStyleBackColor = true;
            // 
            // labelPhotoGalleryUse
            // 
            this.labelPhotoGalleryUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPhotoGalleryUse.AutoSize = true;
            this.labelPhotoGalleryUse.Location = new System.Drawing.Point(3, 298);
            this.labelPhotoGalleryUse.Name = "labelPhotoGalleryUse";
            this.labelPhotoGalleryUse.Size = new System.Drawing.Size(113, 17);
            this.labelPhotoGalleryUse.TabIndex = 9;
            this.labelPhotoGalleryUse.Text = "Galería de fotos:";
            // 
            // textboxBody
            // 
            this.textboxBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxBody.Location = new System.Drawing.Point(68, 94);
            this.textboxBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxBody.MaxLength = 0;
            this.textboxBody.Multiline = true;
            this.textboxBody.Name = "textboxBody";
            this.textboxBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxBody.Size = new System.Drawing.Size(617, 173);
            this.textboxBody.TabIndex = 8;
            this.textboxBody.Enter += new System.EventHandler(this.TextboxsGotFocus);
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(3, 97);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(47, 17);
            this.labelBody.TabIndex = 7;
            this.labelBody.Text = "Texto:";
            // 
            // textboxImageName
            // 
            this.textboxImageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxImageName.Location = new System.Drawing.Point(68, 64);
            this.textboxImageName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxImageName.MaxLength = 255;
            this.textboxImageName.Name = "textboxImageName";
            this.textboxImageName.Size = new System.Drawing.Size(582, 22);
            this.textboxImageName.TabIndex = 5;
            this.textboxImageName.Enter += new System.EventHandler(this.TextboxsGotFocus);
            // 
            // labelImageName
            // 
            this.labelImageName.AutoSize = true;
            this.labelImageName.Location = new System.Drawing.Point(3, 68);
            this.labelImageName.Name = "labelImageName";
            this.labelImageName.Size = new System.Drawing.Size(58, 17);
            this.labelImageName.TabIndex = 4;
            this.labelImageName.Text = "Imágen:";
            // 
            // textboxTitle
            // 
            this.textboxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxTitle.Location = new System.Drawing.Point(68, 34);
            this.textboxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxTitle.MaxLength = 255;
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(617, 22);
            this.textboxTitle.TabIndex = 3;
            this.textboxTitle.Enter += new System.EventHandler(this.TextboxsGotFocus);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(3, 38);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(47, 17);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Título:";
            // 
            // textboxArticleID
            // 
            this.textboxArticleID.Location = new System.Drawing.Point(68, 5);
            this.textboxArticleID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxArticleID.MaxLength = 100;
            this.textboxArticleID.Name = "textboxArticleID";
            this.textboxArticleID.Size = new System.Drawing.Size(284, 22);
            this.textboxArticleID.TabIndex = 1;
            this.tooltipMain.SetToolTip(this.textboxArticleID, "Ingrese un texto para identificar el artículo. Este texto es de uso interno y no " +
        "se muestra en la Newsletter.\r\nEjemplo: \"diafamilia\".");
            this.textboxArticleID.Enter += new System.EventHandler(this.TextboxsGotFocus);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(3, 7);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 17);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.planelSplit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppTitle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.planelSplit.Panel1.ResumeLayout(false);
            this.planelSplit.Panel2.ResumeLayout(false);
            this.planelSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planelSplit)).EndInit();
            this.planelSplit.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelArticlesButtons.ResumeLayout(false);
            this.panelArticlesButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer planelSplit;
        private System.Windows.Forms.TableLayoutPanel panelLeft;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ListBox listboxArticles;
        private System.Windows.Forms.Label labelArticles;
        private System.Windows.Forms.ComboBox comboboxNewsletter;
        private System.Windows.Forms.Label labelNewsletter;
        private System.Windows.Forms.FlowLayoutPanel panelArticlesButtons;
        private System.Windows.Forms.Button buttonArticleAdd;
        private System.Windows.Forms.Button buttonArticleEdit;
        private System.Windows.Forms.Button buttonArticleDelete;
        private System.Windows.Forms.ToolTip tooltipMain;
        private System.Windows.Forms.TextBox textboxArticleID;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textboxImageName;
        private System.Windows.Forms.Label labelImageName;
        private System.Windows.Forms.TextBox textboxBody;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.CheckBox checkboxPhotoGalleryUse;
        private System.Windows.Forms.Label labelPhotoGalleryUse;
        private System.Windows.Forms.TextBox textboxPhotoGalleryID;
        private System.Windows.Forms.Label labelPhotoGalleryID;
        private System.Windows.Forms.NumericUpDown updownOrder;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Button buttonImageName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}

