Public Class TimesModelo
    Private sNome_ As String
    Private iPontuacao_ As Int32
    Private iQtdVitorias_ As Int32
    Private iQtdEmpates_ As Int32
    Private iQtdDerrotas_ As Int32
    Private iQtdGolsFeitos_ As Int32
    Private iQtdGolsTomados_ As Int32
    Private iColocacao_ As Int32


    Public Property SNome As String
        Get
            Return sNome_
        End Get
        Set(value As String)
            sNome_ = value
        End Set
    End Property

    Public Property IPontuacao As Integer
        Get
            Return iPontuacao_
        End Get
        Set(value As Integer)
            iPontuacao_ = value
        End Set
    End Property

    Public Property IQtdVitorias As Integer
        Get
            Return iQtdVitorias_
        End Get
        Set(value As Integer)
            iQtdVitorias_ = value
        End Set
    End Property

    Public Property IQtdEmpates As Integer
        Get
            Return iQtdEmpates_
        End Get
        Set(value As Integer)
            iQtdEmpates_ = value
        End Set
    End Property

    Public Property IQtdDerrotas As Integer
        Get
            Return iQtdDerrotas_
        End Get
        Set(value As Integer)
            iQtdDerrotas_ = value
        End Set
    End Property

    Public Property IQtdGolsFeitos_1 As Integer
        Get
            Return iQtdGolsFeitos_
        End Get
        Set(value As Integer)
            iQtdGolsFeitos_ = value
        End Set
    End Property

    Public Property IQtdGolsTomados As Integer
        Get
            Return iQtdGolsTomados_
        End Get
        Set(value As Integer)
            iQtdGolsTomados_ = value
        End Set
    End Property
    Public Property IColocacao As Integer
        Get
            Return iColocacao_
        End Get
        Set(value As Integer)
            iColocacao_ = value
        End Set
    End Property
End Class
