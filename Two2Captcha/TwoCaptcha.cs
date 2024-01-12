using EasyAutomationFramework;
using TwoCaptcha;

namespace AppAutomacao.Two2Captcha
{
    public class TwoCaptcha
    {
        public async void SolveReCaptchaV2()
        {
            // Acessa o site demo do recaptcha
            const string link = "https://www.google.com/recaptcha/api2/demo";
            var web = new Web();
            web.StartBrowser();
            web.Navigate(link);
            web.WaitForLoad();

            // Pega o dado e o envia para ser resolvido pela API 2Captcha  
            var captcha_Key = web.GetValue(TypeElement.Id, "recaptcha-demo").element.GetAttribute("data-sitekey");
            var solve = new Solve();
            var result = await solve.ReCaptchaV2Async(Key_2Captcha.Key, captcha_Key, link);

            // Inseri e envia a solução retornada pela a API na pagina
            web.ExecuteScript($"document.querySelector('#g-recaptcha-response').innerHTML = '{result.Request}';");
            web.Click(TypeElement.Id, "recaptcha-demo-submit");
        }
    }
}
