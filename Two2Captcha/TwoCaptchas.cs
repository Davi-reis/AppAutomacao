using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EasyAutomationFramework;
using OpenQA.Selenium.Support.Extensions;
using TwoCaptcha;
using TwoCaptcha.Captcha;
using javax.swing.text.html;
using OpenQA.Selenium.Support.UI;
using org.bouncycastle.jce.provider.asymmetric.ec;
using SeleniumExtras.WaitHelpers;
using javax.print;

namespace AppAutomacao.Two2Captcha
{
    public class TwoCaptchas
    {
        public IWebDriver driver;

        public async void SolveReCaptchaV2()
        {
            driver = new ChromeDriver();            
                        
            const string link = "https://2captcha.com/demo/hcaptcha";
            driver.Navigate().GoToUrl(link);
            Thread.Sleep(2000);

            TwoCaptcha.TwoCaptcha solver = new TwoCaptcha.TwoCaptcha(Key_2Captcha.Key);
            HCaptcha captcha = new HCaptcha();
            captcha.SetSiteKey("f7de0da3-3303-44e8-ab48-fa32ff8ccc7b");
            captcha.SetUrl(link);
            captcha.SetData("foo");
            captcha.SetSoftId(123);

            IWebElement elements = driver.FindElement(By.TagName("textarea"));
            



            try
            {               

                string captchaId = await solver.Send(captcha);
                Thread.Sleep(20 * 1000);

                string code = await solver.GetResult(captchaId);
               
                code = "P1_eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.hKdwYXNza2V5xQUVAK9NNXiNicgYtg5bOkqlXa2pG4JnoWcCI148pdUxiZiPe3-oZ_qK5YEcnYlAYIGx9CqsliYiZFtzqOmnEIsoYVgOI_Y00kjmHkBCnB_ihvioM4HrFHJMjJgpl__Al_bZm3vPxj2tbhDoDmjpLuHqJAeCiB5Blf--OaF2DGMQCEh075-CTOVhzQeCiy7TQ10EyAN2tiVBdvxNWGfCG_mbVr_Tnz-phlOKseIUW2OJ8oQK_wsJZuRpn8_TRLHvk7RDgToD1M6Y1PLM0RNZddUlP8Qa7vp3FM-zbAsNx1g-ntpMaH3drUDXhEOQwQetka9jbUZnn60NppnvcC1dTaJGN304GaH_VyLlkIEjOqzwpZGOhMUgnrYhqyIFdgqb0NCbQfYdXhq8-B3Cb8IwFow23EoxZOciTjmCnWNYeXpbQA7HVCV5FJu3mcKMSR1zedIE682lCuqVCgHi2GmqDJ1hsReiKPwoXduKxa-dWJAX1_DJKQgfcJHi9-jUNULt71PuysEk1v3E72RqQjk5XLLMcc0E9qhzvj3D7D8-wt0872cnP2IyahoUztDmYyK0M9xTMSLIxeopUixSztkFUd9Ykvld2udu2uicerar4GrnhL8hzSlPC1_kSeaoY6Kr9vlO_Zq80OdHUrtHfWc-bPeWe8O78RJbA5g3YrysbssXQBmXPAP-QkzjGM483JDW6U14aP-ETEGbJ09wukTgCHMHU3Mc_YWEzx-eiFKi-7NAkw77U-ozV8rALJMhPy6CFluXbDroVJw974pdMbhwwx64Tlwfcf0ninMClo2GP2MKRIV7pzCel4gjNMfUA878MP8zm0QBZtLvGPlQ2Fo2kAL7CMbJU1ZhP0nnwAh5pONb4WNNbXCnl3JqBKu75WKj-EcsvC5mAe21ALyWCf7hn3zXRxGnNdeTksfk5byZtA2DGByA7MRSWgR7qGS-cKtckQfxPiCq4lljAvjHZZuzzx3w6OFmVICfwBx4tC15vXp2XMToeO2s_YDv7EiDGjnidXcg5axFU5Op7Fu46RYMv7nibLSO38rtL6U-8djApiAhqB1l2xMXlp17T4XcHeYPGQ5wcZN9QNaLu9JnXZUreqlU2uaVleHjO2PqsJvE65b8LNmowzyqBv9ma9VUK1CKYVJ3Pinc9m_4BkSu2_G6BeHmUsK-4vlTPPfVddXlrOCTG_KoxcZ3Xanvq1IVYiiMLf4JeMdITJXAwxWOsVzz5g43TUq6RTAUAnVBJlw_LOkXIsqtKPbNH5iiD-6aP3vprYhPbNby42x_G0PPzfmSMfSLI4KsyqlgWXhtFKZcntgkb_WVSNeaNcdP9E184GJROODbalU5I8arq56j0jnr0D2xlcY4w9F3MCjYq65FLrTTr28IuLm045lLIQ5JoMo7ZiSv9iFOsVJWd-V0-sb8D1D7fu7iNUjGmJiYsXy5PmVlScVhdaIS5CKOefgOQgHhye-c1r-d5y_lOdR6qVJtuqO63TNbDNQq_5xZ0WsviS7KsZn1jRvIztR2pUle2UmAQfOIfNj3N7kjO1JK_fqJBpxbKkJjTNAru1leHfq_AFBPEDK6RZNl4ixB9qEAYjF2mGk-tDFqmF6LYotr78fEbOhgmdAM_CEb0hbQ9RsfU28iO7QQ-7rrsqQCGv-FoWmw5Xxa9wpnLvy7N9PfJAeLRpcYTm8JI8I3JJGe9uStDEAoASgbfaT2chzm_XCFNGKrA23cQDuxqkyjZXhwzmWlWreoc2hhcmRfaWTOAzGDb6JwZAA.eperuibVVoSXoqkGUYITz7I40jo2yZiEjFvxFBWQ9bg";

                if (code != null)
                {
                    
                    IWebElement webElement = driver.FindElement(By.Name("h-captcha-response"));
                    webElement.SendKeys(code);
                                        
                    driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div/section/form/button[1]")).Click();
                }               

            }
            catch (AggregateException e)
            {

                Console.WriteLine("Error occurred: " + e.InnerExceptions.First().Message);
            }              
        }
    }
}
