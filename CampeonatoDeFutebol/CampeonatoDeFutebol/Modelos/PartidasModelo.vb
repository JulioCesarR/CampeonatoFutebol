Imports CampeonatoDeFutebol

Public Class PartidasModelo
    Private cTime1_ As TimesModelo
    Private iQtdGolsTime1_ As Int32
    Private cTime2_ As TimesModelo
    Private iQtdGolsTime2_ As Int32

    Public Property CTime1 As TimesModelo
        Get
            Return cTime1_
        End Get
        Set(value As TimesModelo)
            cTime1_ = value
        End Set
    End Property

    Public Property IQtdGolsTime1 As Integer
        Get
            Return iQtdGolsTime1_
        End Get
        Set(value As Integer)
            iQtdGolsTime1_ = value
        End Set
    End Property

    Public Property CTime2 As TimesModelo
        Get
            Return cTime2_
        End Get
        Set(value As TimesModelo)
            cTime2_ = value
        End Set
    End Property

    Public Property IQtdGolsTime2 As Integer
        Get
            Return iQtdGolsTime2_
        End Get
        Set(value As Integer)
            iQtdGolsTime2_ = value
        End Set
    End Property
End Class
