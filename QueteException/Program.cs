namespace QueteException
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ThrowError();
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Date);
            }
            static void ThrowError()
            {
                throw new CustomException("Houston ? On a un problème !");

            }
        }
    }
}
