namespace HelloWorld.Web.Api.Models
{
    public class HelloWorldResponse<T>
    {
        public bool IsSuccessful;
        public T Body;
    }
}