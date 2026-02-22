using System;

class ChallengeFour
{
    static void Main(string[] args)
    {
        string[,] corporate = { { "Robert", "Bavin" }, { "Simon", "Bright" }, { "Kim", "Sinclair" }, { "Aashrita", "Kamath" }, { "Sarah", "Delucchi" }, { "Sinan", "Ali" } };
        string[,] external = { { "Vinnie", "Ashton" }, { "Cody", "Dysart" }, { "Shay", "Lawrence" }, { "Daren", "Valdes" } };
        string corporateDomain = "contoso.com";
        string externalDomain = "hayworth.com";
        string domain = "";
        bool containsValue = false;

        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            string firstNameCorporate = corporate[i, 0];
            string lastNameCorporate = corporate[i, 1];
            string emailName = firstNameCorporate.Remove(2).ToLower() + lastNameCorporate.ToLower();


            if (corporate.OfType<string>().Contains(firstNameCorporate))
            {
                containsValue = true;
            }

            if (containsValue)
            {
                domain = corporateDomain;
            }
            Console.WriteLine(assignDomain(emailName, domain));
        }

        for (int i = 0; i < external.GetLength(0); i++)
        {
            string firstNameExternal = external[i, 0];
            string lastNameExternal = external[i, 1];
            string emailName = firstNameExternal.Remove(2).ToLower() + lastNameExternal.ToLower();


            if (external.OfType<string>().Contains(firstNameExternal))
            {
                containsValue = true;
            }
            if (containsValue)
            {
                domain = externalDomain;
            }
            Console.WriteLine(assignDomain(emailName, domain));
        }
    }

    static string assignDomain(string emailName, string domain)
    {
        return $"{emailName}@{domain}";
    }
}