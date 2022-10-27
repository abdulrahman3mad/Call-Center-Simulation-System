namespace MultiQueueSimulation
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.simulationView = new System.Windows.Forms.DataGridView();
            this.delayingQueueLength = new System.Windows.Forms.Label();
            this.totalDelayingTime = new System.Windows.Forms.Label();
            this.customerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalRandomValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interarrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceRandomTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBeginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.simulationView)).BeginInit();
            this.SuspendLayout();
            // 
            // simulationView
            // 
            this.simulationView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.simulationView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.simulationView.ColumnHeadersHeight = 48;
            this.simulationView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumber,
            this.arrivalRandomValue,
            this.interarrivalTime,
            this.arrivalTime,
            this.serviceRandomTime,
            this.serverId,
            this.serviceBeginTime,
            this.serviceTime,
            this.serviceEndTime,
            this.delayTime});
            this.simulationView.Dock = System.Windows.Forms.DockStyle.Left;
            this.simulationView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.simulationView.Location = new System.Drawing.Point(0, 0);
            this.simulationView.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.simulationView.Name = "simulationView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.simulationView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.simulationView.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            this.simulationView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.simulationView.RowTemplate.Height = 24;
            this.simulationView.Size = new System.Drawing.Size(1610, 769);
            this.simulationView.TabIndex = 1;
            // 
            // delayingQueueLength
            // 
            this.delayingQueueLength.AutoSize = true;
            this.delayingQueueLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayingQueueLength.Location = new System.Drawing.Point(1630, 32);
            this.delayingQueueLength.Name = "delayingQueueLength";
            this.delayingQueueLength.Size = new System.Drawing.Size(196, 18);
            this.delayingQueueLength.TabIndex = 2;
            this.delayingQueueLength.Text = "Max Delaying Queue Length:";
            // 
            // totalDelayingTime
            // 
            this.totalDelayingTime.AutoSize = true;
            this.totalDelayingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDelayingTime.Location = new System.Drawing.Point(1630, 92);
            this.totalDelayingTime.Name = "totalDelayingTime";
            this.totalDelayingTime.Size = new System.Drawing.Size(142, 18);
            this.totalDelayingTime.TabIndex = 3;
            this.totalDelayingTime.Text = "Total Delaying Time:";
            // 
            // customerNumber
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customerNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.customerNumber.FillWeight = 116.4295F;
            this.customerNumber.HeaderText = "Customer No.";
            this.customerNumber.MinimumWidth = 6;
            this.customerNumber.Name = "customerNumber";
            this.customerNumber.Width = 150;
            // 
            // arrivalRandomValue
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.arrivalRandomValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.arrivalRandomValue.FillWeight = 171.2605F;
            this.arrivalRandomValue.HeaderText = "Random Digits for Arrival ";
            this.arrivalRandomValue.MinimumWidth = 6;
            this.arrivalRandomValue.Name = "arrivalRandomValue";
            this.arrivalRandomValue.Width = 221;
            // 
            // interarrivalTime
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.interarrivalTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.interarrivalTime.FillWeight = 141.2931F;
            this.interarrivalTime.HeaderText = "Time between Arrivals";
            this.interarrivalTime.MinimumWidth = 6;
            this.interarrivalTime.Name = "interarrivalTime";
            this.interarrivalTime.Width = 182;
            // 
            // arrivalTime
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.arrivalTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.arrivalTime.FillWeight = 138.5286F;
            this.arrivalTime.HeaderText = "Clock Time of Arrival";
            this.arrivalTime.MinimumWidth = 6;
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Width = 178;
            // 
            // serviceRandomTime
            // 
            this.serviceRandomTime.FillWeight = 128.3648F;
            this.serviceRandomTime.HeaderText = "Random Digits for Service";
            this.serviceRandomTime.MinimumWidth = 6;
            this.serviceRandomTime.Name = "serviceRandomTime";
            this.serviceRandomTime.Width = 200;
            // 
            // serverId
            // 
            this.serverId.FillWeight = 74.69732F;
            this.serverId.HeaderText = "Server Id";
            this.serverId.MinimumWidth = 6;
            this.serverId.Name = "serverId";
            this.serverId.Width = 96;
            // 
            // serviceBeginTime
            // 
            this.serviceBeginTime.FillWeight = 117.6094F;
            this.serviceBeginTime.HeaderText = "Time Service Begins ";
            this.serviceBeginTime.MinimumWidth = 6;
            this.serviceBeginTime.Name = "serviceBeginTime";
            this.serviceBeginTime.Width = 151;
            // 
            // serviceTime
            // 
            this.serviceTime.FillWeight = 110.1518F;
            this.serviceTime.HeaderText = "Service Time";
            this.serviceTime.MinimumWidth = 6;
            this.serviceTime.Name = "serviceTime";
            this.serviceTime.Width = 142;
            // 
            // serviceEndTime
            // 
            this.serviceEndTime.FillWeight = 103.6589F;
            this.serviceEndTime.HeaderText = "Time Service Ends";
            this.serviceEndTime.MinimumWidth = 6;
            this.serviceEndTime.Name = "serviceEndTime";
            this.serviceEndTime.Width = 200;
            // 
            // delayTime
            // 
            this.delayTime.FillWeight = 98.006F;
            this.delayTime.HeaderText = "Time in Queue";
            this.delayTime.MinimumWidth = 6;
            this.delayTime.Name = "delayTime";
            this.delayTime.Width = 126;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 769);
            this.Controls.Add(this.totalDelayingTime);
            this.Controls.Add(this.delayingQueueLength);
            this.Controls.Add(this.simulationView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simulationView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView simulationView;
        private System.Windows.Forms.Label delayingQueueLength;
        private System.Windows.Forms.Label totalDelayingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalRandomValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn interarrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceRandomTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceBeginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayTime;
    }
}

