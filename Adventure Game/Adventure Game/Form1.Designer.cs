namespace Adventure_Game
{
    partial class frm_AdventureGame
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
            this.btn_bottomLeft = new System.Windows.Forms.Button();
            this.btn_BottomRight = new System.Windows.Forms.Button();
            this.btn_topRight = new System.Windows.Forms.Button();
            this.btn_topLeft = new System.Windows.Forms.Button();
            this.btn_bigButton = new System.Windows.Forms.Button();
            this.pic_Game = new System.Windows.Forms.PictureBox();
            this.lbl_inventory = new System.Windows.Forms.Label();
            this.lbl_Pineapple = new System.Windows.Forms.Label();
            this.lbl_bow = new System.Windows.Forms.Label();
            this.lbl_sword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Game)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bottomLeft
            // 
            this.btn_bottomLeft.Location = new System.Drawing.Point(16, 448);
            this.btn_bottomLeft.Name = "btn_bottomLeft";
            this.btn_bottomLeft.Size = new System.Drawing.Size(249, 73);
            this.btn_bottomLeft.TabIndex = 3;
            this.btn_bottomLeft.Text = " ";
            this.btn_bottomLeft.UseVisualStyleBackColor = true;
            this.btn_bottomLeft.Click += new System.EventHandler(this.btn_bottomLeft_Click);
            // 
            // btn_BottomRight
            // 
            this.btn_BottomRight.Location = new System.Drawing.Point(307, 448);
            this.btn_BottomRight.Name = "btn_BottomRight";
            this.btn_BottomRight.Size = new System.Drawing.Size(249, 73);
            this.btn_BottomRight.TabIndex = 4;
            this.btn_BottomRight.Text = " ";
            this.btn_BottomRight.UseVisualStyleBackColor = true;
            this.btn_BottomRight.Click += new System.EventHandler(this.btn_BottomRight_Click);
            // 
            // btn_topRight
            // 
            this.btn_topRight.Location = new System.Drawing.Point(307, 369);
            this.btn_topRight.Name = "btn_topRight";
            this.btn_topRight.Size = new System.Drawing.Size(249, 73);
            this.btn_topRight.TabIndex = 5;
            this.btn_topRight.Text = " ";
            this.btn_topRight.UseVisualStyleBackColor = true;
            this.btn_topRight.Click += new System.EventHandler(this.btn_topRight_Click);
            // 
            // btn_topLeft
            // 
            this.btn_topLeft.Location = new System.Drawing.Point(16, 369);
            this.btn_topLeft.Name = "btn_topLeft";
            this.btn_topLeft.Size = new System.Drawing.Size(249, 73);
            this.btn_topLeft.TabIndex = 6;
            this.btn_topLeft.Text = " ";
            this.btn_topLeft.UseVisualStyleBackColor = true;
            this.btn_topLeft.Click += new System.EventHandler(this.btn_topLeft_Click);
            // 
            // btn_bigButton
            // 
            this.btn_bigButton.Location = new System.Drawing.Point(16, 290);
            this.btn_bigButton.Name = "btn_bigButton";
            this.btn_bigButton.Size = new System.Drawing.Size(540, 73);
            this.btn_bigButton.TabIndex = 7;
            this.btn_bigButton.Text = "Start Adventure";
            this.btn_bigButton.UseVisualStyleBackColor = true;
            this.btn_bigButton.Click += new System.EventHandler(this.btn_bigButton_Click);
            // 
            // pic_Game
            // 
            this.pic_Game.Location = new System.Drawing.Point(107, 12);
            this.pic_Game.Name = "pic_Game";
            this.pic_Game.Size = new System.Drawing.Size(368, 272);
            this.pic_Game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Game.TabIndex = 8;
            this.pic_Game.TabStop = false;
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.AutoSize = true;
            this.lbl_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventory.Location = new System.Drawing.Point(482, 12);
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(86, 24);
            this.lbl_inventory.TabIndex = 9;
            this.lbl_inventory.Text = "Inventory";
            // 
            // lbl_Pineapple
            // 
            this.lbl_Pineapple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pineapple.Location = new System.Drawing.Point(482, 72);
            this.lbl_Pineapple.Name = "lbl_Pineapple";
            this.lbl_Pineapple.Size = new System.Drawing.Size(79, 74);
            this.lbl_Pineapple.TabIndex = 10;
            this.lbl_Pineapple.Text = "Pineapple";
            // 
            // lbl_bow
            // 
            this.lbl_bow.AutoSize = true;
            this.lbl_bow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bow.Location = new System.Drawing.Point(482, 52);
            this.lbl_bow.Name = "lbl_bow";
            this.lbl_bow.Size = new System.Drawing.Size(40, 20);
            this.lbl_bow.TabIndex = 11;
            this.lbl_bow.Text = "Bow";
            // 
            // lbl_sword
            // 
            this.lbl_sword.AutoSize = true;
            this.lbl_sword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sword.Location = new System.Drawing.Point(482, 36);
            this.lbl_sword.Name = "lbl_sword";
            this.lbl_sword.Size = new System.Drawing.Size(54, 20);
            this.lbl_sword.TabIndex = 12;
            this.lbl_sword.Text = "Sword";
            // 
            // frm_AdventureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(568, 530);
            this.Controls.Add(this.lbl_sword);
            this.Controls.Add(this.lbl_bow);
            this.Controls.Add(this.lbl_Pineapple);
            this.Controls.Add(this.lbl_inventory);
            this.Controls.Add(this.pic_Game);
            this.Controls.Add(this.btn_bigButton);
            this.Controls.Add(this.btn_topLeft);
            this.Controls.Add(this.btn_topRight);
            this.Controls.Add(this.btn_BottomRight);
            this.Controls.Add(this.btn_bottomLeft);
            this.Name = "frm_AdventureGame";
            this.Text = "Adventure Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Game)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bottomLeft;
        private System.Windows.Forms.Button btn_BottomRight;
        private System.Windows.Forms.Button btn_topRight;
        private System.Windows.Forms.Button btn_topLeft;
        private System.Windows.Forms.Button btn_bigButton;
        private System.Windows.Forms.PictureBox pic_Game;
        private System.Windows.Forms.Label lbl_inventory;
        private System.Windows.Forms.Label lbl_Pineapple;
        private System.Windows.Forms.Label lbl_bow;
        private System.Windows.Forms.Label lbl_sword;
    }
}

