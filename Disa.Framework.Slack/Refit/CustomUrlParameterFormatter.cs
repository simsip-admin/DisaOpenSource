using Refit;
using System.Reflection;


namespace Models.Refit
{
    public class CustomUrlParameterFormatter : DefaultUrlParameterFormatter
    {
        public override string Format(object parameterValue, ParameterInfo parameterInfo)
        {
            if (parameterValue == null)
                return null;

            if (parameterInfo.Name == "token")
            {
                return Disa.Framework.Slack.SlackMessenger.Token;
            }

            return base.Format(parameterValue, parameterInfo);
        }
    }
}
