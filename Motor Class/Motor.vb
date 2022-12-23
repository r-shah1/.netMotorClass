Public Class Motor
    Private strID As String                 'holds ID number
    Private strDescription As String        'hold description
    Private sngRPM As Single                'holds motor RPMs
    Private sngVoltage As Single            'Holds motor voltage rating
    Private strStatus As String             'Holds motor status

    'Starting Value Constructor
    Public Sub New()
        strID = String.Empty
        strDescription = String.Empty
        sngRPM = 0
        sngVoltage = 0
        strStatus = String.Empty
    End Sub

    'Get Values
    'Motor ID
    Public Property MotorID() As String
        Get
            Return strID
        End Get
        Set(ByVal value As String)
            strID = value
        End Set
    End Property
    'Motor Description  
    Public Property Description() As String
        Get
            Return strDescription
        End Get
        Set(ByVal value As String)
            strDescription = value
        End Set
    End Property
    'Motor RPM
    Public Property RPM() As Single
        Get
            Return sngRPM
        End Get
        Set(ByVal value As Single)
            sngRPM = value
        End Set
    End Property
    'Motor Voltage
    Public Property Voltage() As Single
        Get
            Return sngVoltage
        End Get
        Set(ByVal value As Single)
            sngVoltage = value
        End Set
    End Property
    'Motor Status
    Public Property Status() As String
        Get
            Return strStatus
        End Get
        Set(ByVal value As String)
            strStatus = value
        End Set
    End Property
End Class
