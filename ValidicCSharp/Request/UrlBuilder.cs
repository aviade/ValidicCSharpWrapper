namespace ValidicCSharp.Request
{
    using System.Linq;

    public class UrlBuilder
    {
        public static string FromCommand(Command command)
        {
            var target = "";

            // User
            if (command.UserId != null)
                target = "/" + command.UserId + target;
            if (command.User)
                target = "/users" + target;

            // Organization
            if (command.OrganizationId != null)
                target = "/" + command.OrganizationId + target;
            if (command.Organization)
                target = "organizations" + target;

            if (command.Type != CommandType.None)
                target += "/" + command.Type.ToString().ToLower() + (command.Latest ? "/latest" : "") + ".json";

            else if (command.Type == CommandType.None && (command.UserId != null || command.Payload != null)) target += ".json";
            else target += "/";

            target += "?nocache=" + command.NoCache;
            if (command.Filters != null && command.Filters.Count > 0)
                target = command.Filters.Aggregate(target, (current, commandFilter) => current + commandFilter.ToString());

            return target;

        }

        public static string GetRequestAccessUrl(string organizationId, string authenticationToken)
        {
            return $"{organizationId}/{authenticationToken}/";
        }
    }
}
