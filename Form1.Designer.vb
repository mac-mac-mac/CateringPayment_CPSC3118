<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picPlatters = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblStoreName = New System.Windows.Forms.Label()
        Me.grpPlatters = New System.Windows.Forms.GroupBox()
        Me.radGC = New System.Windows.Forms.RadioButton()
        Me.radPW = New System.Windows.Forms.RadioButton()
        Me.radV = New System.Windows.Forms.RadioButton()
        Me.radSC = New System.Windows.Forms.RadioButton()
        Me.radF = New System.Windows.Forms.RadioButton()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.lblPayTitle = New System.Windows.Forms.Label()
        Me.lblPayMessage = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picPlatters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlatters.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPlatters
        '
        Me.picPlatters.Image = Global.CateringPayment_CPSC3118.My.Resources.Resources.platter
        Me.picPlatters.Location = New System.Drawing.Point(438, 12)
        Me.picPlatters.Name = "picPlatters"
        Me.picPlatters.Size = New System.Drawing.Size(350, 200)
        Me.picPlatters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlatters.TabIndex = 0
        Me.picPlatters.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(150, 12)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(118, 32)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Catering"
        '
        'lblStoreName
        '
        Me.lblStoreName.AutoSize = True
        Me.lblStoreName.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoreName.Location = New System.Drawing.Point(152, 44)
        Me.lblStoreName.Name = "lblStoreName"
        Me.lblStoreName.Size = New System.Drawing.Size(113, 22)
        Me.lblStoreName.TabIndex = 2
        Me.lblStoreName.Text = "Star Market"
        '
        'grpPlatters
        '
        Me.grpPlatters.BackColor = System.Drawing.Color.MistyRose
        Me.grpPlatters.Controls.Add(Me.radF)
        Me.grpPlatters.Controls.Add(Me.radSC)
        Me.grpPlatters.Controls.Add(Me.radV)
        Me.grpPlatters.Controls.Add(Me.radPW)
        Me.grpPlatters.Controls.Add(Me.radGC)
        Me.grpPlatters.Location = New System.Drawing.Point(76, 82)
        Me.grpPlatters.Name = "grpPlatters"
        Me.grpPlatters.Size = New System.Drawing.Size(291, 175)
        Me.grpPlatters.TabIndex = 3
        Me.grpPlatters.TabStop = False
        '
        'radGC
        '
        Me.radGC.AutoSize = True
        Me.radGC.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGC.Location = New System.Drawing.Point(7, 11)
        Me.radGC.Name = "radGC"
        Me.radGC.Size = New System.Drawing.Size(236, 22)
        Me.radGC.TabIndex = 0
        Me.radGC.TabStop = True
        Me.radGC.Text = "Gourmet Cheese $49.99"
        Me.radGC.UseVisualStyleBackColor = True
        '
        'radPW
        '
        Me.radPW.AutoSize = True
        Me.radPW.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPW.Location = New System.Drawing.Point(7, 44)
        Me.radPW.Name = "radPW"
        Me.radPW.Size = New System.Drawing.Size(236, 22)
        Me.radPW.TabIndex = 1
        Me.radPW.TabStop = True
        Me.radPW.Text = "Pinwheel Wraps $59.99"
        Me.radPW.UseVisualStyleBackColor = True
        '
        'radV
        '
        Me.radV.AutoSize = True
        Me.radV.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radV.Location = New System.Drawing.Point(7, 77)
        Me.radV.Name = "radV"
        Me.radV.Size = New System.Drawing.Size(156, 22)
        Me.radV.TabIndex = 2
        Me.radV.TabStop = True
        Me.radV.Text = "Veggie $29.99"
        Me.radV.UseVisualStyleBackColor = True
        '
        'radSC
        '
        Me.radSC.AutoSize = True
        Me.radSC.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSC.Location = New System.Drawing.Point(7, 110)
        Me.radSC.Name = "radSC"
        Me.radSC.Size = New System.Drawing.Size(276, 22)
        Me.radSC.TabIndex = 3
        Me.radSC.TabStop = True
        Me.radSC.Text = "Sausage and Cheese $49.99"
        Me.radSC.UseVisualStyleBackColor = True
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radF.Location = New System.Drawing.Point(6, 143)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(146, 22)
        Me.radF.TabIndex = 4
        Me.radF.TabStop = True
        Me.radF.Text = "Fruit $29.99"
        Me.radF.UseVisualStyleBackColor = True
        '
        'grpPayment
        '
        Me.grpPayment.BackColor = System.Drawing.Color.MistyRose
        Me.grpPayment.Controls.Add(Me.radPickup)
        Me.grpPayment.Controls.Add(Me.radPrePay)
        Me.grpPayment.Location = New System.Drawing.Point(129, 276)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(190, 76)
        Me.grpPayment.TabIndex = 4
        Me.grpPayment.TabStop = False
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrePay.Location = New System.Drawing.Point(7, 11)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(96, 22)
        Me.radPrePay.TabIndex = 0
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-Pay"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPickup.Location = New System.Drawing.Point(7, 40)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(176, 22)
        Me.radPickup.TabIndex = 1
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pay upon Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'lblPayTitle
        '
        Me.lblPayTitle.AutoSize = True
        Me.lblPayTitle.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayTitle.Location = New System.Drawing.Point(77, 378)
        Me.lblPayTitle.Name = "lblPayTitle"
        Me.lblPayTitle.Size = New System.Drawing.Size(118, 25)
        Me.lblPayTitle.TabIndex = 5
        Me.lblPayTitle.Text = "Please Pay:"
        '
        'lblPayMessage
        '
        Me.lblPayMessage.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayMessage.Location = New System.Drawing.Point(227, 378)
        Me.lblPayMessage.Name = "lblPayMessage"
        Me.lblPayMessage.Size = New System.Drawing.Size(533, 63)
        Me.lblPayMessage.TabIndex = 6
        Me.lblPayMessage.Text = "Your order XXXXXXXXXXXXXX platter costs $XX.XX using XXXXXXXXXXXXX after discount" &
    " of XX loyalty points."
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(483, 238)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(114, 19)
        Me.lblPoints.TabIndex = 7
        Me.lblPoints.Text = "Loyalty Points"
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Location = New System.Drawing.Point(646, 235)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(59, 26)
        Me.txtPoints.TabIndex = 8
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCalc.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(482, 309)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(115, 34)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PeachPuff
        Me.btnClear.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(646, 309)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 34)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblPayMessage)
        Me.Controls.Add(Me.lblPayTitle)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpPlatters)
        Me.Controls.Add(Me.lblStoreName)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picPlatters)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        CType(Me.picPlatters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlatters.ResumeLayout(False)
        Me.grpPlatters.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlatters As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblStoreName As Label
    Friend WithEvents grpPlatters As GroupBox
    Friend WithEvents radF As RadioButton
    Friend WithEvents radSC As RadioButton
    Friend WithEvents radV As RadioButton
    Friend WithEvents radPW As RadioButton
    Friend WithEvents radGC As RadioButton
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents lblPayTitle As Label
    Friend WithEvents lblPayMessage As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
End Class
