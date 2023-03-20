namespace WindowsFormsApplication1
{
    partial class Wishlist1
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
            this.Wishlistbox = new System.Windows.Forms.ListBox();
            this.wishlistTitle = new System.Windows.Forms.Label();
            this.fillButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.Selection = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.selectionOutputBox1 = new System.Windows.Forms.TextBox();
            this.countOut = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // Wishlistbox
            // 
            this.Wishlistbox.FormattingEnabled = true;
            this.Wishlistbox.Location = new System.Drawing.Point(44, 47);
            this.Wishlistbox.Name = "Wishlistbox";
            this.Wishlistbox.Size = new System.Drawing.Size(194, 173);
            this.Wishlistbox.TabIndex = 0;
            this.Wishlistbox.SelectedIndexChanged += new System.EventHandler(this.Wishlistbox_SelectedIndexChanged);
            // 
            // wishlistTitle
            // 
            this.wishlistTitle.AutoSize = true;
            this.wishlistTitle.Font = new System.Drawing.Font("Futura Maxi CG Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wishlistTitle.Location = new System.Drawing.Point(41, 17);
            this.wishlistTitle.Name = "wishlistTitle";
            this.wishlistTitle.Size = new System.Drawing.Size(77, 22);
            this.wishlistTitle.TabIndex = 1;
            this.wishlistTitle.Text = "Wishlist";
            this.wishlistTitle.Click += new System.EventHandler(this.wishlistText_Click);
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(283, 47);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 2;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(283, 148);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(283, 197);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 4;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // Selection
            // 
            this.Selection.AutoSize = true;
            this.Selection.Font = new System.Drawing.Font("Futura Maxi CG Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selection.Location = new System.Drawing.Point(42, 251);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(77, 18);
            this.Selection.TabIndex = 5;
            this.Selection.Text = "Selection:";
            this.Selection.Click += new System.EventHandler(this.label2_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Futura Maxi CG Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.Location = new System.Drawing.Point(42, 299);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(54, 18);
            this.Count.TabIndex = 7;
            this.Count.Text = "Count:";
            // 
            // selectionOutputBox1
            // 
            this.selectionOutputBox1.Location = new System.Drawing.Point(121, 249);
            this.selectionOutputBox1.Name = "selectionOutputBox1";
            this.selectionOutputBox1.Size = new System.Drawing.Size(117, 20);
            this.selectionOutputBox1.TabIndex = 8;
            this.selectionOutputBox1.TextChanged += new System.EventHandler(this.selectionOutputBox1_TextChanged);
            // 
            // countOut
            // 
            this.countOut.Location = new System.Drawing.Point(121, 299);
            this.countOut.Name = "countOut";
            this.countOut.Size = new System.Drawing.Size(117, 20);
            this.countOut.TabIndex = 9;
            this.countOut.TextChanged += new System.EventHandler(this.countOut_TextChanged);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(283, 95);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 10;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(283, 251);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Wishlist1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 385);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.countOut);
            this.Controls.Add(this.selectionOutputBox1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.wishlistTitle);
            this.Controls.Add(this.Wishlistbox);
            this.Name = "Wishlist1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Wishlistbox;
        private System.Windows.Forms.Label wishlistTitle;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label Selection;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.TextBox selectionOutputBox1;
        private System.Windows.Forms.TextBox countOut;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

