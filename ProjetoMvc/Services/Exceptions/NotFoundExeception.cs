using System;


namespace ProjetoMvc.Services.Exceptions
{
    public class NotFoundExeception : ApplicationException
    {
        // Exceção personalizada
        public NotFoundExeception(string message) : base(message)
        {

        }
    }
    
}
