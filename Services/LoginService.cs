public class LoginService
{
    public int Id { get; set; }
    public string? User { get; set; }
    public string? Password { get; set; }
    public bool Logado { get; set; } = false;

    // @Inject BookService estava impedindo a página Delete de carregar, então coloquei o contúdo dele aqui.
    public int BookId { get; set; }

    public int GetBookId()
    {
        return(BookId);
    }
    // -----------------------------------------------------------------------------------------------------
    // Repeti o processo do BookService com o LoanService para evitar erros.
    public int LoanId { get; set; }

    public int GetLoanId()
    {
        return(LoanId);
    }
    // -----------------------------------------------------------------------------------------------------

    public void LogOut()
    {
        Id = 0;
        User = null;
        Logado = false;
    }

    public int GetId()
    {
        return(Id);
    }
}