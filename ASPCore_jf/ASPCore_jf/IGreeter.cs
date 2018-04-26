using Microsoft.Extensions.Configuration;

namespace ASPCore_jf
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();


    }


    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public string GetMessageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}