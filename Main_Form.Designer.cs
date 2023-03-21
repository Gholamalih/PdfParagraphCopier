
namespace GTrans
{
    partial class Main_Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Destination_TextBox = new System.Windows.Forms.TextBox();
            this.Source_TextBox = new System.Windows.Forms.TextBox();
            this.sharpClipboard1 = new WK.Libraries.SharpClipboardNS.SharpClipboard(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Destination_TextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Source_TextBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Destination_TextBox
            // 
            this.Destination_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Destination_TextBox.Location = new System.Drawing.Point(3, 228);
            this.Destination_TextBox.Multiline = true;
            this.Destination_TextBox.Name = "Destination_TextBox";
            this.Destination_TextBox.Size = new System.Drawing.Size(427, 219);
            this.Destination_TextBox.TabIndex = 1;
            // 
            // Source_TextBox
            // 
            this.Source_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Source_TextBox.Location = new System.Drawing.Point(3, 3);
            this.Source_TextBox.Multiline = true;
            this.Source_TextBox.Name = "Source_TextBox";
            this.Source_TextBox.Size = new System.Drawing.Size(427, 219);
            this.Source_TextBox.TabIndex = 0;
            this.Source_TextBox.TextChanged += new System.EventHandler(this.Source_TextBox_TextChanged);
            // 
            // sharpClipboard1
            // 
            this.sharpClipboard1.MonitorClipboard = true;
            this.sharpClipboard1.ObservableFormats.All = true;
            this.sharpClipboard1.ObservableFormats.Files = true;
            this.sharpClipboard1.ObservableFormats.Images = true;
            this.sharpClipboard1.ObservableFormats.Others = true;
            this.sharpClipboard1.ObservableFormats.Texts = true;
            this.sharpClipboard1.ObserveLastEntry = true;
            this.sharpClipboard1.Tag = null;
            this.sharpClipboard1.ClipboardChanged += new System.EventHandler<WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs>(this.sharpClipboard1_ClipboardChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PDF Paragraph Copy Amender";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Destination_TextBox;
        private System.Windows.Forms.TextBox Source_TextBox;
        private WK.Libraries.SharpClipboardNS.SharpClipboard sharpClipboard1;
    }
}

