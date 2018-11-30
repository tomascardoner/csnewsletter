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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
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
            this.updownOrderNumber = new System.Windows.Forms.NumericUpDown();
            this.labelOrderNumber = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.updownOrderNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // planelSplit
            // 
            this.planelSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planelSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planelSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.planelSplit.Location = new System.Drawing.Point(0, 0);
            this.planelSplit.Margin = new System.Windows.Forms.Padding(2);
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
            this.planelSplit.Panel2.Controls.Add(this.updownOrderNumber);
            this.planelSplit.Panel2.Controls.Add(this.labelOrderNumber);
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
            this.planelSplit.Size = new System.Drawing.Size(650, 366);
            this.planelSplit.SplitterDistance = 266;
            this.planelSplit.SplitterWidth = 6;
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
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.RowCount = 5;
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLeft.Size = new System.Drawing.Size(264, 364);
            this.panelLeft.TabIndex = 0;
            // 
            // listboxArticles
            // 
            this.listboxArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxArticles.FormattingEnabled = true;
            this.listboxArticles.Location = new System.Drawing.Point(2, 69);
            this.listboxArticles.Margin = new System.Windows.Forms.Padding(2);
            this.listboxArticles.Name = "listboxArticles";
            this.listboxArticles.Size = new System.Drawing.Size(260, 229);
            this.listboxArticles.TabIndex = 3;
            this.listboxArticles.SelectedIndexChanged += new System.EventHandler(this.ArticleChange);
            // 
            // labelArticles
            // 
            this.labelArticles.AutoSize = true;
            this.labelArticles.Location = new System.Drawing.Point(4, 50);
            this.labelArticles.Margin = new System.Windows.Forms.Padding(4);
            this.labelArticles.Name = "labelArticles";
            this.labelArticles.Size = new System.Drawing.Size(52, 13);
            this.labelArticles.TabIndex = 2;
            this.labelArticles.Text = "Artículos:";
            // 
            // comboboxNewsletter
            // 
            this.comboboxNewsletter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxNewsletter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNewsletter.FormattingEnabled = true;
            this.comboboxNewsletter.Location = new System.Drawing.Point(2, 23);
            this.comboboxNewsletter.Margin = new System.Windows.Forms.Padding(2);
            this.comboboxNewsletter.Name = "comboboxNewsletter";
            this.comboboxNewsletter.Size = new System.Drawing.Size(260, 21);
            this.comboboxNewsletter.TabIndex = 1;
            this.comboboxNewsletter.SelectedIndexChanged += new System.EventHandler(this.NewsletterChange);
            // 
            // labelNewsletter
            // 
            this.labelNewsletter.AutoSize = true;
            this.labelNewsletter.Location = new System.Drawing.Point(4, 4);
            this.labelNewsletter.Margin = new System.Windows.Forms.Padding(4);
            this.labelNewsletter.Name = "labelNewsletter";
            this.labelNewsletter.Size = new System.Drawing.Size(60, 13);
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
            this.panelArticlesButtons.Location = new System.Drawing.Point(2, 302);
            this.panelArticlesButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelArticlesButtons.Name = "panelArticlesButtons";
            this.panelArticlesButtons.Size = new System.Drawing.Size(260, 60);
            this.panelArticlesButtons.TabIndex = 4;
            // 
            // buttonArticleAdd
            // 
            this.buttonArticleAdd.AutoSize = true;
            this.buttonArticleAdd.Image = global::CSNewsletter.Properties.Resources.ADD;
            this.buttonArticleAdd.Location = new System.Drawing.Point(2, 2);
            this.buttonArticleAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArticleAdd.Name = "buttonArticleAdd";
            this.buttonArticleAdd.Size = new System.Drawing.Size(54, 54);
            this.buttonArticleAdd.TabIndex = 0;
            this.tooltipMain.SetToolTip(this.buttonArticleAdd, "Agregar artículo");
            this.buttonArticleAdd.UseVisualStyleBackColor = true;
            this.buttonArticleAdd.Click += new System.EventHandler(this.ArticleAdd);
            // 
            // buttonArticleEdit
            // 
            this.buttonArticleEdit.AutoSize = true;
            this.buttonArticleEdit.Image = global::CSNewsletter.Properties.Resources.EDIT;
            this.buttonArticleEdit.Location = new System.Drawing.Point(60, 2);
            this.buttonArticleEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArticleEdit.Name = "buttonArticleEdit";
            this.buttonArticleEdit.Size = new System.Drawing.Size(54, 54);
            this.buttonArticleEdit.TabIndex = 1;
            this.tooltipMain.SetToolTip(this.buttonArticleEdit, "Editar artículo");
            this.buttonArticleEdit.UseVisualStyleBackColor = true;
            this.buttonArticleEdit.Click += new System.EventHandler(this.ArticleEdit);
            // 
            // buttonArticleDelete
            // 
            this.buttonArticleDelete.AutoSize = true;
            this.buttonArticleDelete.Image = global::CSNewsletter.Properties.Resources.DELETE;
            this.buttonArticleDelete.Location = new System.Drawing.Point(118, 2);
            this.buttonArticleDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArticleDelete.Name = "buttonArticleDelete";
            this.buttonArticleDelete.Size = new System.Drawing.Size(54, 54);
            this.buttonArticleDelete.TabIndex = 2;
            this.tooltipMain.SetToolTip(this.buttonArticleDelete, "Eliminar artículo");
            this.buttonArticleDelete.UseVisualStyleBackColor = true;
            this.buttonArticleDelete.Click += new System.EventHandler(this.ArticleDelete);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Image = global::CSNewsletter.Properties.Resources.CANCEL;
            this.buttonCancel.Location = new System.Drawing.Point(308, 305);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(54, 54);
            this.buttonCancel.TabIndex = 16;
            this.tooltipMain.SetToolTip(this.buttonCancel, "Agregar artículo");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.AutoSize = true;
            this.buttonOk.Image = global::CSNewsletter.Properties.Resources.OK;
            this.buttonOk.Location = new System.Drawing.Point(4, 306);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(54, 54);
            this.buttonOk.TabIndex = 15;
            this.tooltipMain.SetToolTip(this.buttonOk, "Agregar artículo");
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.OkClick);
            // 
            // buttonImageName
            // 
            this.buttonImageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImageName.Location = new System.Drawing.Point(337, 52);
            this.buttonImageName.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImageName.Name = "buttonImageName";
            this.buttonImageName.Size = new System.Drawing.Size(24, 20);
            this.buttonImageName.TabIndex = 6;
            this.buttonImageName.Text = "...";
            this.tooltipMain.SetToolTip(this.buttonImageName, "Examinar...");
            this.buttonImageName.UseVisualStyleBackColor = true;
            // 
            // updownOrderNumber
            // 
            this.updownOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updownOrderNumber.Location = new System.Drawing.Point(51, 266);
            this.updownOrderNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updownOrderNumber.Name = "updownOrderNumber";
            this.updownOrderNumber.Size = new System.Drawing.Size(57, 20);
            this.updownOrderNumber.TabIndex = 14;
            this.updownOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Location = new System.Drawing.Point(2, 268);
            this.labelOrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(39, 13);
            this.labelOrderNumber.TabIndex = 13;
            this.labelOrderNumber.Text = "Orden:";
            // 
            // labelPhotoGalleryID
            // 
            this.labelPhotoGalleryID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPhotoGalleryID.AutoSize = true;
            this.labelPhotoGalleryID.Location = new System.Drawing.Point(129, 242);
            this.labelPhotoGalleryID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhotoGalleryID.Name = "labelPhotoGalleryID";
            this.labelPhotoGalleryID.Size = new System.Drawing.Size(21, 13);
            this.labelPhotoGalleryID.TabIndex = 11;
            this.labelPhotoGalleryID.Text = "ID:";
            // 
            // textboxPhotoGalleryID
            // 
            this.textboxPhotoGalleryID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxPhotoGalleryID.Location = new System.Drawing.Point(154, 239);
            this.textboxPhotoGalleryID.Margin = new System.Windows.Forms.Padding(2);
            this.textboxPhotoGalleryID.MaxLength = 100;
            this.textboxPhotoGalleryID.Name = "textboxPhotoGalleryID";
            this.textboxPhotoGalleryID.Size = new System.Drawing.Size(214, 20);
            this.textboxPhotoGalleryID.TabIndex = 12;
            this.tooltipMain.SetToolTip(this.textboxPhotoGalleryID, "Ingrese un texto para identificar el artículo. Este texto es de uso interno y no " +
        "se muestra en la Newsletter.\r\nEjemplo: \"diafamilia\".");
            this.textboxPhotoGalleryID.Enter += new System.EventHandler(this.TextboxsGotFocus);
            // 
            // checkboxPhotoGalleryUse
            // 
            this.checkboxPhotoGalleryUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxPhotoGalleryUse.AutoSize = true;
            this.checkboxPhotoGalleryUse.Location = new System.Drawing.Point(93, 242);
            this.checkboxPhotoGalleryUse.Name = "checkboxPhotoGalleryUse";
            this.checkboxPhotoGalleryUse.Size = new System.Drawing.Size(15, 14);
            this.checkboxPhotoGalleryUse.TabIndex = 10;
            this.checkboxPhotoGalleryUse.UseVisualStyleBackColor = true;
            // 
            // labelPhotoGalleryUse
            // 
            this.labelPhotoGalleryUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPhotoGalleryUse.AutoSize = true;
            this.labelPhotoGalleryUse.Location = new System.Drawing.Point(2, 242);
            this.labelPhotoGalleryUse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhotoGalleryUse.Name = "labelPhotoGalleryUse";
            this.labelPhotoGalleryUse.Size = new System.Drawing.Size(86, 13);
            this.labelPhotoGalleryUse.TabIndex = 9;
            this.labelPhotoGalleryUse.Text = "Galería de fotos:";
            // 
            // textboxBody
            // 
            this.textboxBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxBody.Location = new System.Drawing.Point(51, 76);
            this.textboxBody.Margin = new System.Windows.Forms.Padding(2);
            this.textboxBody.MaxLength = 0;
            this.textboxBody.Multiline = true;
            this.textboxBody.Name = "textboxBody";
            this.textboxBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxBody.Size = new System.Drawing.Size(309, 141);
            this.textboxBody.TabIndex = 8;
            this.textboxBody.Enter += new System.EventHandler(this.BodyFocusEnter);
            this.textboxBody.Leave += new System.EventHandler(this.BodyFocusLeave);
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(2, 79);
            this.labelBody.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(37, 13);
            this.labelBody.TabIndex = 7;
            this.labelBody.Text = "Texto:";
            // 
            // textboxImageName
            // 
            this.textboxImageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxImageName.Location = new System.Drawing.Point(51, 52);
            this.textboxImageName.Margin = new System.Windows.Forms.Padding(2);
            this.textboxImageName.MaxLength = 255;
            this.textboxImageName.Name = "textboxImageName";
            this.textboxImageName.Size = new System.Drawing.Size(282, 20);
            this.textboxImageName.TabIndex = 5;
            this.textboxImageName.Enter += new System.EventHandler(this.TextboxsGotFocus);
            // 
            // labelImageName
            // 
            this.labelImageName.AutoSize = true;
            this.labelImageName.Location = new System.Drawing.Point(2, 55);
            this.labelImageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImageName.Name = "labelImageName";
            this.labelImageName.Size = new System.Drawing.Size(45, 13);
            this.labelImageName.TabIndex = 4;
            this.labelImageName.Text = "Imágen:";
            // 
            // textboxTitle
            // 
            this.textboxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxTitle.Location = new System.Drawing.Point(51, 28);
            this.textboxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textboxTitle.MaxLength = 255;
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(309, 20);
            this.textboxTitle.TabIndex = 3;
            this.textboxTitle.Enter += new System.EventHandler(this.TextboxsGotFocus);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(2, 31);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(38, 13);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Título:";
            // 
            // textboxArticleID
            // 
            this.textboxArticleID.Location = new System.Drawing.Point(51, 4);
            this.textboxArticleID.Margin = new System.Windows.Forms.Padding(2);
            this.textboxArticleID.MaxLength = 100;
            this.textboxArticleID.Name = "textboxArticleID";
            this.textboxArticleID.Size = new System.Drawing.Size(214, 20);
            this.textboxArticleID.TabIndex = 1;
            this.tooltipMain.SetToolTip(this.textboxArticleID, "Ingrese un texto para identificar el artículo. Este texto es de uso interno y no " +
        "se muestra en la Newsletter.\r\nEjemplo: \"diafamilia\".");
            this.textboxArticleID.Enter += new System.EventHandler(this.TextboxsGotFocus);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(2, 6);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // formMain
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(650, 366);
            this.Controls.Add(this.planelSplit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.updownOrderNumber)).EndInit();
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
        private System.Windows.Forms.NumericUpDown updownOrderNumber;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Button buttonImageName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}

