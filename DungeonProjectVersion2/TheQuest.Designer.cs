
namespace DungeonProjectVersion2
{
    partial class TheQuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheQuest));
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbBat = new System.Windows.Forms.PictureBox();
            this.pbGhost = new System.Windows.Forms.PictureBox();
            this.pbGhoul = new System.Windows.Forms.PictureBox();
            this.pbRedPotion1 = new System.Windows.Forms.PictureBox();
            this.pbRedPotion2 = new System.Windows.Forms.PictureBox();
            this.pbSword = new System.Windows.Forms.PictureBox();
            this.pbBow = new System.Windows.Forms.PictureBox();
            this.pbMace = new System.Windows.Forms.PictureBox();
            this.pbSwordInv = new System.Windows.Forms.PictureBox();
            this.pbBowInv = new System.Windows.Forms.PictureBox();
            this.pbMaceInv = new System.Windows.Forms.PictureBox();
            this.pbBluePotionInv = new System.Windows.Forms.PictureBox();
            this.pbRedPotionInv = new System.Windows.Forms.PictureBox();
            this.gbMove = new System.Windows.Forms.GroupBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.gbAttack = new System.Windows.Forms.GroupBox();
            this.btnAtkLeft = new System.Windows.Forms.Button();
            this.btnAtkDown = new System.Windows.Forms.Button();
            this.btnAtkUp = new System.Windows.Forms.Button();
            this.btnAtkRight = new System.Windows.Forms.Button();
            this.tlpScoreBoard = new System.Windows.Forms.TableLayoutPanel();
            this.lblGhoulHitPoints = new System.Windows.Forms.Label();
            this.lblGhostHitPoints = new System.Windows.Forms.Label();
            this.lblBatHitPoints = new System.Windows.Forms.Label();
            this.lblPlayerHitPoints = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblBat = new System.Windows.Forms.Label();
            this.lblGhost = new System.Windows.Forms.Label();
            this.lblGhoul = new System.Windows.Forms.Label();
            this.btnDrink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPotion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPotion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwordInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaceInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluePotionInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPotionInv)).BeginInit();
            this.gbMove.SuspendLayout();
            this.gbAttack.SuspendLayout();
            this.tlpScoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(110, 70);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 50);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbBat
            // 
            this.pbBat.BackColor = System.Drawing.Color.Transparent;
            this.pbBat.Image = ((System.Drawing.Image)(resources.GetObject("pbBat.Image")));
            this.pbBat.Location = new System.Drawing.Point(166, 70);
            this.pbBat.Name = "pbBat";
            this.pbBat.Size = new System.Drawing.Size(50, 50);
            this.pbBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBat.TabIndex = 1;
            this.pbBat.TabStop = false;
            this.pbBat.Visible = false;
            // 
            // pbGhost
            // 
            this.pbGhost.BackColor = System.Drawing.Color.Transparent;
            this.pbGhost.Image = ((System.Drawing.Image)(resources.GetObject("pbGhost.Image")));
            this.pbGhost.Location = new System.Drawing.Point(222, 70);
            this.pbGhost.Name = "pbGhost";
            this.pbGhost.Size = new System.Drawing.Size(50, 50);
            this.pbGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbGhost.TabIndex = 2;
            this.pbGhost.TabStop = false;
            this.pbGhost.Visible = false;
            // 
            // pbGhoul
            // 
            this.pbGhoul.BackColor = System.Drawing.Color.Transparent;
            this.pbGhoul.Image = ((System.Drawing.Image)(resources.GetObject("pbGhoul.Image")));
            this.pbGhoul.Location = new System.Drawing.Point(278, 70);
            this.pbGhoul.Name = "pbGhoul";
            this.pbGhoul.Size = new System.Drawing.Size(50, 50);
            this.pbGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbGhoul.TabIndex = 3;
            this.pbGhoul.TabStop = false;
            this.pbGhoul.Visible = false;
            // 
            // pbRedPotion1
            // 
            this.pbRedPotion1.BackColor = System.Drawing.Color.Transparent;
            this.pbRedPotion1.Image = ((System.Drawing.Image)(resources.GetObject("pbRedPotion1.Image")));
            this.pbRedPotion1.Location = new System.Drawing.Point(334, 70);
            this.pbRedPotion1.Name = "pbRedPotion1";
            this.pbRedPotion1.Size = new System.Drawing.Size(50, 50);
            this.pbRedPotion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRedPotion1.TabIndex = 4;
            this.pbRedPotion1.TabStop = false;
            this.pbRedPotion1.Visible = false;
            // 
            // pbRedPotion2
            // 
            this.pbRedPotion2.BackColor = System.Drawing.Color.Transparent;
            this.pbRedPotion2.Image = ((System.Drawing.Image)(resources.GetObject("pbRedPotion2.Image")));
            this.pbRedPotion2.Location = new System.Drawing.Point(390, 70);
            this.pbRedPotion2.Name = "pbRedPotion2";
            this.pbRedPotion2.Size = new System.Drawing.Size(50, 50);
            this.pbRedPotion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRedPotion2.TabIndex = 5;
            this.pbRedPotion2.TabStop = false;
            this.pbRedPotion2.Visible = false;
            // 
            // pbSword
            // 
            this.pbSword.BackColor = System.Drawing.Color.Transparent;
            this.pbSword.Image = ((System.Drawing.Image)(resources.GetObject("pbSword.Image")));
            this.pbSword.Location = new System.Drawing.Point(446, 70);
            this.pbSword.Name = "pbSword";
            this.pbSword.Size = new System.Drawing.Size(50, 50);
            this.pbSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSword.TabIndex = 6;
            this.pbSword.TabStop = false;
            this.pbSword.Visible = false;
            // 
            // pbBow
            // 
            this.pbBow.BackColor = System.Drawing.Color.Transparent;
            this.pbBow.Image = ((System.Drawing.Image)(resources.GetObject("pbBow.Image")));
            this.pbBow.Location = new System.Drawing.Point(502, 70);
            this.pbBow.Name = "pbBow";
            this.pbBow.Size = new System.Drawing.Size(50, 50);
            this.pbBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBow.TabIndex = 7;
            this.pbBow.TabStop = false;
            this.pbBow.Visible = false;
            // 
            // pbMace
            // 
            this.pbMace.BackColor = System.Drawing.Color.Transparent;
            this.pbMace.Image = ((System.Drawing.Image)(resources.GetObject("pbMace.Image")));
            this.pbMace.Location = new System.Drawing.Point(558, 70);
            this.pbMace.Name = "pbMace";
            this.pbMace.Size = new System.Drawing.Size(50, 50);
            this.pbMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMace.TabIndex = 8;
            this.pbMace.TabStop = false;
            this.pbMace.Visible = false;
            // 
            // pbSwordInv
            // 
            this.pbSwordInv.BackColor = System.Drawing.Color.Transparent;
            this.pbSwordInv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSwordInv.Image = ((System.Drawing.Image)(resources.GetObject("pbSwordInv.Image")));
            this.pbSwordInv.Location = new System.Drawing.Point(110, 350);
            this.pbSwordInv.Name = "pbSwordInv";
            this.pbSwordInv.Size = new System.Drawing.Size(73, 73);
            this.pbSwordInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSwordInv.TabIndex = 9;
            this.pbSwordInv.TabStop = false;
            this.pbSwordInv.Click += new System.EventHandler(this.pbSwordInv_Click);
            // 
            // pbBowInv
            // 
            this.pbBowInv.BackColor = System.Drawing.Color.Transparent;
            this.pbBowInv.Image = ((System.Drawing.Image)(resources.GetObject("pbBowInv.Image")));
            this.pbBowInv.Location = new System.Drawing.Point(189, 350);
            this.pbBowInv.Name = "pbBowInv";
            this.pbBowInv.Size = new System.Drawing.Size(75, 75);
            this.pbBowInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBowInv.TabIndex = 10;
            this.pbBowInv.TabStop = false;
            this.pbBowInv.Click += new System.EventHandler(this.pbBowInv_Click);
            // 
            // pbMaceInv
            // 
            this.pbMaceInv.BackColor = System.Drawing.Color.Transparent;
            this.pbMaceInv.Image = ((System.Drawing.Image)(resources.GetObject("pbMaceInv.Image")));
            this.pbMaceInv.Location = new System.Drawing.Point(270, 350);
            this.pbMaceInv.Name = "pbMaceInv";
            this.pbMaceInv.Size = new System.Drawing.Size(75, 75);
            this.pbMaceInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaceInv.TabIndex = 11;
            this.pbMaceInv.TabStop = false;
            this.pbMaceInv.Click += new System.EventHandler(this.pbMaceInv_Click);
            // 
            // pbBluePotionInv
            // 
            this.pbBluePotionInv.BackColor = System.Drawing.Color.Transparent;
            this.pbBluePotionInv.Image = ((System.Drawing.Image)(resources.GetObject("pbBluePotionInv.Image")));
            this.pbBluePotionInv.Location = new System.Drawing.Point(351, 350);
            this.pbBluePotionInv.Name = "pbBluePotionInv";
            this.pbBluePotionInv.Size = new System.Drawing.Size(75, 75);
            this.pbBluePotionInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBluePotionInv.TabIndex = 12;
            this.pbBluePotionInv.TabStop = false;
            this.pbBluePotionInv.Click += new System.EventHandler(this.pbBluePotionInv_Click);
            // 
            // pbRedPotionInv
            // 
            this.pbRedPotionInv.BackColor = System.Drawing.Color.Transparent;
            this.pbRedPotionInv.Image = ((System.Drawing.Image)(resources.GetObject("pbRedPotionInv.Image")));
            this.pbRedPotionInv.Location = new System.Drawing.Point(432, 350);
            this.pbRedPotionInv.Name = "pbRedPotionInv";
            this.pbRedPotionInv.Size = new System.Drawing.Size(75, 75);
            this.pbRedPotionInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRedPotionInv.TabIndex = 13;
            this.pbRedPotionInv.TabStop = false;
            this.pbRedPotionInv.Click += new System.EventHandler(this.pbRedPotionInv_Click);
            // 
            // gbMove
            // 
            this.gbMove.BackColor = System.Drawing.Color.Transparent;
            this.gbMove.Controls.Add(this.btnMoveLeft);
            this.gbMove.Controls.Add(this.btnMoveDown);
            this.gbMove.Controls.Add(this.btnMoveUp);
            this.gbMove.Controls.Add(this.btnMoveRight);
            this.gbMove.Location = new System.Drawing.Point(513, 350);
            this.gbMove.Name = "gbMove";
            this.gbMove.Size = new System.Drawing.Size(139, 72);
            this.gbMove.TabIndex = 14;
            this.gbMove.TabStop = false;
            this.gbMove.Text = "Move";
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(38, 21);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(25, 25);
            this.btnMoveLeft.TabIndex = 19;
            this.btnMoveLeft.Text = "←";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(69, 41);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(25, 25);
            this.btnMoveDown.TabIndex = 18;
            this.btnMoveDown.Text = "↓";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(69, 3);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(25, 25);
            this.btnMoveUp.TabIndex = 17;
            this.btnMoveUp.Text = "↑";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(100, 21);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(25, 25);
            this.btnMoveRight.TabIndex = 16;
            this.btnMoveRight.Text = "→";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // gbAttack
            // 
            this.gbAttack.BackColor = System.Drawing.Color.Transparent;
            this.gbAttack.Controls.Add(this.btnDrink);
            this.gbAttack.Controls.Add(this.btnAtkLeft);
            this.gbAttack.Controls.Add(this.btnAtkDown);
            this.gbAttack.Controls.Add(this.btnAtkUp);
            this.gbAttack.Controls.Add(this.btnAtkRight);
            this.gbAttack.Location = new System.Drawing.Point(658, 353);
            this.gbAttack.Name = "gbAttack";
            this.gbAttack.Size = new System.Drawing.Size(139, 72);
            this.gbAttack.TabIndex = 15;
            this.gbAttack.TabStop = false;
            this.gbAttack.Text = "Attack";
            // 
            // btnAtkLeft
            // 
            this.btnAtkLeft.Location = new System.Drawing.Point(46, 18);
            this.btnAtkLeft.Name = "btnAtkLeft";
            this.btnAtkLeft.Size = new System.Drawing.Size(25, 25);
            this.btnAtkLeft.TabIndex = 23;
            this.btnAtkLeft.Text = "←";
            this.btnAtkLeft.UseVisualStyleBackColor = true;
            this.btnAtkLeft.Click += new System.EventHandler(this.btnAtkLeft_Click);
            // 
            // btnAtkDown
            // 
            this.btnAtkDown.Location = new System.Drawing.Point(77, 38);
            this.btnAtkDown.Name = "btnAtkDown";
            this.btnAtkDown.Size = new System.Drawing.Size(25, 25);
            this.btnAtkDown.TabIndex = 22;
            this.btnAtkDown.Text = "↓";
            this.btnAtkDown.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAtkDown.UseVisualStyleBackColor = true;
            this.btnAtkDown.Click += new System.EventHandler(this.btnAtkDown_Click);
            // 
            // btnAtkUp
            // 
            this.btnAtkUp.Location = new System.Drawing.Point(77, 0);
            this.btnAtkUp.Name = "btnAtkUp";
            this.btnAtkUp.Size = new System.Drawing.Size(25, 25);
            this.btnAtkUp.TabIndex = 21;
            this.btnAtkUp.Text = "↑";
            this.btnAtkUp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAtkUp.UseVisualStyleBackColor = true;
            this.btnAtkUp.Click += new System.EventHandler(this.btnAtkUp_Click);
            // 
            // btnAtkRight
            // 
            this.btnAtkRight.Location = new System.Drawing.Point(108, 18);
            this.btnAtkRight.Name = "btnAtkRight";
            this.btnAtkRight.Size = new System.Drawing.Size(25, 25);
            this.btnAtkRight.TabIndex = 20;
            this.btnAtkRight.Text = "→";
            this.btnAtkRight.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAtkRight.UseVisualStyleBackColor = true;
            this.btnAtkRight.Click += new System.EventHandler(this.btnAtkRight_Click);
            // 
            // tlpScoreBoard
            // 
            this.tlpScoreBoard.BackColor = System.Drawing.Color.Transparent;
            this.tlpScoreBoard.ColumnCount = 2;
            this.tlpScoreBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpScoreBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpScoreBoard.Controls.Add(this.lblGhoulHitPoints, 1, 3);
            this.tlpScoreBoard.Controls.Add(this.lblGhostHitPoints, 1, 2);
            this.tlpScoreBoard.Controls.Add(this.lblBatHitPoints, 1, 1);
            this.tlpScoreBoard.Controls.Add(this.lblPlayerHitPoints, 1, 0);
            this.tlpScoreBoard.Controls.Add(this.lblPlayer, 0, 0);
            this.tlpScoreBoard.Controls.Add(this.lblBat, 0, 1);
            this.tlpScoreBoard.Controls.Add(this.lblGhost, 0, 2);
            this.tlpScoreBoard.Controls.Add(this.lblGhoul, 0, 3);
            this.tlpScoreBoard.Location = new System.Drawing.Point(582, 272);
            this.tlpScoreBoard.Name = "tlpScoreBoard";
            this.tlpScoreBoard.RowCount = 4;
            this.tlpScoreBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpScoreBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpScoreBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpScoreBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpScoreBoard.Size = new System.Drawing.Size(190, 69);
            this.tlpScoreBoard.TabIndex = 16;
            // 
            // lblGhoulHitPoints
            // 
            this.lblGhoulHitPoints.AutoSize = true;
            this.lblGhoulHitPoints.Location = new System.Drawing.Point(79, 51);
            this.lblGhoulHitPoints.Name = "lblGhoulHitPoints";
            this.lblGhoulHitPoints.Size = new System.Drawing.Size(102, 17);
            this.lblGhoulHitPoints.TabIndex = 7;
            this.lblGhoulHitPoints.Text = "GhoulHitPoints";
            // 
            // lblGhostHitPoints
            // 
            this.lblGhostHitPoints.AutoSize = true;
            this.lblGhostHitPoints.Location = new System.Drawing.Point(79, 34);
            this.lblGhostHitPoints.Name = "lblGhostHitPoints";
            this.lblGhostHitPoints.Size = new System.Drawing.Size(102, 17);
            this.lblGhostHitPoints.TabIndex = 6;
            this.lblGhostHitPoints.Text = "GhostHitPoints";
            // 
            // lblBatHitPoints
            // 
            this.lblBatHitPoints.AutoSize = true;
            this.lblBatHitPoints.Location = new System.Drawing.Point(79, 17);
            this.lblBatHitPoints.Name = "lblBatHitPoints";
            this.lblBatHitPoints.Size = new System.Drawing.Size(85, 17);
            this.lblBatHitPoints.TabIndex = 5;
            this.lblBatHitPoints.Text = "BatHitPoints";
            // 
            // lblPlayerHitPoints
            // 
            this.lblPlayerHitPoints.AutoSize = true;
            this.lblPlayerHitPoints.Location = new System.Drawing.Point(79, 0);
            this.lblPlayerHitPoints.Name = "lblPlayerHitPoints";
            this.lblPlayerHitPoints.Size = new System.Drawing.Size(104, 17);
            this.lblPlayerHitPoints.TabIndex = 4;
            this.lblPlayerHitPoints.Text = "PlayerHitPoints";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(3, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(48, 17);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player";
            // 
            // lblBat
            // 
            this.lblBat.AutoSize = true;
            this.lblBat.Location = new System.Drawing.Point(3, 17);
            this.lblBat.Name = "lblBat";
            this.lblBat.Size = new System.Drawing.Size(29, 17);
            this.lblBat.TabIndex = 1;
            this.lblBat.Text = "Bat";
            // 
            // lblGhost
            // 
            this.lblGhost.AutoSize = true;
            this.lblGhost.Location = new System.Drawing.Point(3, 34);
            this.lblGhost.Name = "lblGhost";
            this.lblGhost.Size = new System.Drawing.Size(46, 17);
            this.lblGhost.TabIndex = 2;
            this.lblGhost.Text = "Ghost";
            // 
            // lblGhoul
            // 
            this.lblGhoul.AutoSize = true;
            this.lblGhoul.Location = new System.Drawing.Point(3, 51);
            this.lblGhoul.Name = "lblGhoul";
            this.lblGhoul.Size = new System.Drawing.Size(46, 17);
            this.lblGhoul.TabIndex = 3;
            this.lblGhoul.Text = "Ghoul";
            // 
            // btnDrink
            // 
            this.btnDrink.Location = new System.Drawing.Point(47, 18);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(86, 25);
            this.btnDrink.TabIndex = 24;
            this.btnDrink.Text = "Drink";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Visible = false;
            // 
            // TheQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.tlpScoreBoard);
            this.Controls.Add(this.gbAttack);
            this.Controls.Add(this.gbMove);
            this.Controls.Add(this.pbRedPotionInv);
            this.Controls.Add(this.pbBluePotionInv);
            this.Controls.Add(this.pbMaceInv);
            this.Controls.Add(this.pbBowInv);
            this.Controls.Add(this.pbSwordInv);
            this.Controls.Add(this.pbMace);
            this.Controls.Add(this.pbBow);
            this.Controls.Add(this.pbSword);
            this.Controls.Add(this.pbRedPotion2);
            this.Controls.Add(this.pbRedPotion1);
            this.Controls.Add(this.pbGhoul);
            this.Controls.Add(this.pbGhost);
            this.Controls.Add(this.pbBat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TheQuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.TheQuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPotion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPotion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwordInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaceInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluePotionInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPotionInv)).EndInit();
            this.gbMove.ResumeLayout(false);
            this.gbAttack.ResumeLayout(false);
            this.tlpScoreBoard.ResumeLayout(false);
            this.tlpScoreBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbBat;
        private System.Windows.Forms.PictureBox pbGhost;
        private System.Windows.Forms.PictureBox pbGhoul;
        private System.Windows.Forms.PictureBox pbRedPotion1;
        private System.Windows.Forms.PictureBox pbRedPotion2;
        private System.Windows.Forms.PictureBox pbSword;
        private System.Windows.Forms.PictureBox pbBow;
        private System.Windows.Forms.PictureBox pbMace;
        private System.Windows.Forms.PictureBox pbSwordInv;
        private System.Windows.Forms.PictureBox pbBowInv;
        private System.Windows.Forms.PictureBox pbMaceInv;
        private System.Windows.Forms.PictureBox pbBluePotionInv;
        private System.Windows.Forms.PictureBox pbRedPotionInv;
        private System.Windows.Forms.GroupBox gbMove;
        private System.Windows.Forms.GroupBox gbAttack;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnAtkLeft;
        private System.Windows.Forms.Button btnAtkDown;
        private System.Windows.Forms.Button btnAtkUp;
        private System.Windows.Forms.Button btnAtkRight;
        private System.Windows.Forms.TableLayoutPanel tlpScoreBoard;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblBat;
        private System.Windows.Forms.Label lblGhost;
        private System.Windows.Forms.Label lblGhoul;
        private System.Windows.Forms.Label lblGhoulHitPoints;
        private System.Windows.Forms.Label lblGhostHitPoints;
        private System.Windows.Forms.Label lblBatHitPoints;
        private System.Windows.Forms.Label lblPlayerHitPoints;
        private System.Windows.Forms.Button btnDrink;
    }
}

