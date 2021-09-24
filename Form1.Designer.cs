
namespace WindowsFormsAlgorithm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInputNum = new System.Windows.Forms.TextBox();
            this.lbGuide = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInputNum
            // 
            this.tbInputNum.Location = new System.Drawing.Point(32, 60);
            this.tbInputNum.Name = "tbInputNum";
            this.tbInputNum.Size = new System.Drawing.Size(199, 25);
            this.tbInputNum.TabIndex = 0;
            // 
            // lbGuide
            // 
            this.lbGuide.AutoSize = true;
            this.lbGuide.Location = new System.Drawing.Point(29, 38);
            this.lbGuide.Name = "lbGuide";
            this.lbGuide.Size = new System.Drawing.Size(336, 19);
            this.lbGuide.TabIndex = 1;
            this.lbGuide.Text = "1부터 100사이의 숫자를 입력해 주세요";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(29, 143);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(145, 15);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "입력한 숫자의 합은?";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(194, 140);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 25);
            this.tbResult.TabIndex = 3;
            // 
            // btInput
            // 
            this.btInput.Location = new System.Drawing.Point(237, 62);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(75, 23);
            this.btInput.TabIndex = 4;
            this.btInput.Text = "입력";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 199);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbGuide);
            this.Controls.Add(this.tbInputNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputNum;
        private System.Windows.Forms.Label lbGuide;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btInput;
    }
}

