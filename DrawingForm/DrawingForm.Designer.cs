namespace DrawingForm
{
    partial class DrawingForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._undoButton = new System.Windows.Forms.Button();
            this._redoButton = new System.Windows.Forms.Button();
            this._rectangleButton = new System.Windows.Forms.Button();
            this._triangleButton = new System.Windows.Forms.Button();
            this._circleButton = new System.Windows.Forms.Button();
            this._lineButton = new System.Windows.Forms.Button();
            this._saveButton = new System.Windows.Forms.Button();
            this._uploadButton = new System.Windows.Forms.Button();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tableLayoutPanel.ColumnCount = 15;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.28205F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.10256F));
            this._tableLayoutPanel.Controls.Add(this._undoButton, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._redoButton, 2, 1);
            this._tableLayoutPanel.Controls.Add(this._rectangleButton, 4, 1);
            this._tableLayoutPanel.Controls.Add(this._triangleButton, 6, 1);
            this._tableLayoutPanel.Controls.Add(this._circleButton, 8, 1);
            this._tableLayoutPanel.Controls.Add(this._lineButton, 10, 1);
            this._tableLayoutPanel.Controls.Add(this._saveButton, 12, 1);
            this._tableLayoutPanel.Controls.Add(this._uploadButton, 14, 1);
            this._tableLayoutPanel.Controls.Add(this._pictureBox, 0, 2);
            this._tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 2;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(780, 437);
            this._tableLayoutPanel.TabIndex = 1;
            // 
            // _undoButton
            // 
            this._undoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._undoButton.Enabled = false;
            this._undoButton.Location = new System.Drawing.Point(3, 24);
            this._undoButton.Name = "_undoButton";
            this._undoButton.Size = new System.Drawing.Size(70, 26);
            this._undoButton.TabIndex = 1;
            this._undoButton.Text = "Undo";
            this._undoButton.UseVisualStyleBackColor = true;
            this._undoButton.Click += new System.EventHandler(this.ClickUndoButton);
            // 
            // _redoButton
            // 
            this._redoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._redoButton.Enabled = false;
            this._redoButton.Location = new System.Drawing.Point(82, 24);
            this._redoButton.Name = "_redoButton";
            this._redoButton.Size = new System.Drawing.Size(70, 26);
            this._redoButton.TabIndex = 2;
            this._redoButton.Text = "Redo";
            this._redoButton.UseVisualStyleBackColor = true;
            this._redoButton.Click += new System.EventHandler(this.ClickRedoButton);
            // 
            // _rectangleButton
            // 
            this._rectangleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rectangleButton.Location = new System.Drawing.Point(188, 24);
            this._rectangleButton.Name = "_rectangleButton";
            this._rectangleButton.Size = new System.Drawing.Size(70, 26);
            this._rectangleButton.TabIndex = 3;
            this._rectangleButton.Text = "Rectangle";
            this._rectangleButton.UseVisualStyleBackColor = true;
            this._rectangleButton.Click += new System.EventHandler(this.ClickRectangleButton);
            // 
            // _triangleButton
            // 
            this._triangleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._triangleButton.Location = new System.Drawing.Point(267, 24);
            this._triangleButton.Name = "_triangleButton";
            this._triangleButton.Size = new System.Drawing.Size(70, 26);
            this._triangleButton.TabIndex = 4;
            this._triangleButton.Text = "Triangle";
            this._triangleButton.UseVisualStyleBackColor = true;
            this._triangleButton.Click += new System.EventHandler(this.ClickTriangleButton);
            // 
            // _circleButton
            // 
            this._circleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._circleButton.Location = new System.Drawing.Point(346, 24);
            this._circleButton.Name = "_circleButton";
            this._circleButton.Size = new System.Drawing.Size(70, 26);
            this._circleButton.TabIndex = 5;
            this._circleButton.Text = "Circle";
            this._circleButton.UseVisualStyleBackColor = true;
            this._circleButton.Click += new System.EventHandler(this.ClickCircleButton);
            // 
            // _lineButton
            // 
            this._lineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lineButton.Location = new System.Drawing.Point(425, 24);
            this._lineButton.Name = "_lineButton";
            this._lineButton.Size = new System.Drawing.Size(70, 26);
            this._lineButton.TabIndex = 7;
            this._lineButton.Text = "Line";
            this._lineButton.UseVisualStyleBackColor = true;
            this._lineButton.Click += new System.EventHandler(this.ClickLineButton);
            // 
            // _saveButton
            // 
            this._saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._saveButton.Location = new System.Drawing.Point(531, 24);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(80, 26);
            this._saveButton.TabIndex = 6;
            this._saveButton.Text = "Save to bmp";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.ClickSaveButton);
            // 
            // _uploadButton
            // 
            this._uploadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._uploadButton.Location = new System.Drawing.Point(624, 24);
            this._uploadButton.Name = "_uploadButton";
            this._uploadButton.Size = new System.Drawing.Size(153, 26);
            this._uploadButton.TabIndex = 8;
            this._uploadButton.Text = "Upload to Google Drive";
            this._uploadButton.UseVisualStyleBackColor = true;
            this._uploadButton.Click += new System.EventHandler(this.ClickUploadButton);
            // 
            // _pictureBox
            // 
            this._pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this._tableLayoutPanel.SetColumnSpan(this._pictureBox, 15);
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBox.Location = new System.Drawing.Point(3, 56);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(774, 378);
            this._pictureBox.TabIndex = 9;
            this._pictureBox.TabStop = false;
            this._pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.HandlePictureBoxPaint);
            this._pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandlePictureBoxMouseDown);
            this._pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandlePictureBoxMouseMove);
            this._pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandlePictureBoxMouseUp);
            // 
            // EzPaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "EzPaintForm";
            this.Text = "EzPaint";
            this._tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Button _undoButton;
        private System.Windows.Forms.Button _redoButton;
        private System.Windows.Forms.Button _rectangleButton;
        private System.Windows.Forms.Button _triangleButton;
        private System.Windows.Forms.Button _circleButton;
        private System.Windows.Forms.Button _lineButton;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _uploadButton;
        private System.Windows.Forms.PictureBox _pictureBox;
    }
}
