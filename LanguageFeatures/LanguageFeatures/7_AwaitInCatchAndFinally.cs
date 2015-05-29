using System;
using LanguageFeatures.Stuff;

namespace LanguageFeatures
{
    public class AwaitInCatchAndFinally
    {
        public async void DoSomething()
        {
            var service = new AwesomeService();
            try
            {
                await service.MakeSomeMagic();
            }
            catch(Exception ex)
            {
                await LoggingService.Log(ex);
            }
            finally
            {
                await service.Close();
            }
        }
    }
}
