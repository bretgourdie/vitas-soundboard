namespace vitas_soundboard
{
    partial class VitasSoundboardForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.mainTabPageFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainTableLayoutPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.mainTabControl, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(492, 335);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(486, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Vitas Soundboard";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(3, 42);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(486, 290);
            this.mainTabControl.TabIndex = 1;
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.mainTabPageFlowLayoutPanel);
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(478, 264);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Vitas Soundboard";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // mainTabPageFlowLayoutPanel
            // 
            this.mainTabPageFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabPageFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.mainTabPageFlowLayoutPanel.Name = "mainTabPageFlowLayoutPanel";
            this.mainTabPageFlowLayoutPanel.Size = new System.Drawing.Size(472, 258);
            this.mainTabPageFlowLayoutPanel.TabIndex = 0;
            // 
            // VitasSoundboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 335);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "VitasSoundboardForm";
            this.Text = "Vitas Soundboard";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.FlowLayoutPanel mainTabPageFlowLayoutPanel;
    }
}

