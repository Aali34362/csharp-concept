namespace csharp_concept.oops.encapsulation;

public static class PasswordManager_OnlySetter_Program
{
    public static void PasswordManager_OnlySetter_Main()
    {
        PasswordManager_OnlySetter pm = new PasswordManager_OnlySetter();
        // Set the password
        pm.Password = "mySecretPassword123";

        // The following line would cause a compilation error
        // string pwd = pm.Password; // Error: No 'get' accessor

        // Verify the password
        bool isValid = pm.VerifyPassword("mySecretPassword123");
        Console.WriteLine(isValid ? "Password is correct" : "Password is incorrect");



        //Deferred Read Access via Events or Callbacks
        PasswordManager_Deferred_ReadAccess_Events_or_Callbacks pm1 = new PasswordManager_Deferred_ReadAccess_Events_or_Callbacks();
        // Subscribe to the event to capture the value
        pm1.OnPasswordSet += (encryptedPwd) =>
        {
            Console.WriteLine($"Encrypted password was set: {encryptedPwd}");
        };

        pm1.Password = "mySecretPassword123"; // Triggers event and prints the encrypted password
    }
}

//With No Get only Set
public class PasswordManager_OnlySetter
{
    private string encryptedPassword;
    public string Password
    {
        set
        {
            // Encrypt the password and store it internally
            encryptedPassword = EncryptPassword(value);
        }
    }

    private string EncryptPassword(string password)
    {
        // Placeholder encryption logic
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
    }

    // Method to verify the password
    public bool VerifyPassword(string password)
    {
        string encryptedInput = EncryptPassword(password);
        return encryptedPassword == encryptedInput;
    }
}

//Internal or Protected get Accessor
public class PasswordManager_Internal_or_Protected_Get
{
    private string encryptedPassword;

    public string Password
    {
        internal get => encryptedPassword; // Internal get for future use
        set
        {
            encryptedPassword = EncryptPassword(value);
        }
    }

    private string EncryptPassword(string password)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
    }

    public bool VerifyPassword(string password)
    {
        string encryptedInput = EncryptPassword(password);
        return encryptedPassword == encryptedInput;
    }
}

//Private Field with a Public get Method
public class PasswordManager_Private_Field_with_Public_Get
{
    private string encryptedPassword;

    public string Password
    {
        set
        {
            encryptedPassword = EncryptPassword(value);
        }
    }

    private string EncryptPassword(string password)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
    }

    public bool VerifyPassword(string password)
    {
        string encryptedInput = EncryptPassword(password);
        return encryptedPassword == encryptedInput;
    }

    // Future read access
    public string GetEncryptedPassword()
    {
        return encryptedPassword;
    }
}

//Adding a get Accessor Later
public class PasswordManager_Adding_Get_Accessor_Later
{
    private string encryptedPassword;

    public string Password
    {
        get => encryptedPassword; // Added later for read access
        set
        {
            encryptedPassword = EncryptPassword(value);
        }
    }

    private string EncryptPassword(string password)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
    }

    public bool VerifyPassword(string password)
    {
        string encryptedInput = EncryptPassword(password);
        return encryptedPassword == encryptedInput;
    }
}

//Deferred Read Access via Events or Callbacks
public class PasswordManager_Deferred_ReadAccess_Events_or_Callbacks
{
    private string encryptedPassword;

    public string Password
    {
        set
        {
            encryptedPassword = EncryptPassword(value);
            OnPasswordSet?.Invoke(encryptedPassword); // Trigger event on set
        }
    }

    private string EncryptPassword(string password)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
    }

    public event Action<string> OnPasswordSet;

    public bool VerifyPassword(string password)
    {
        string encryptedInput = EncryptPassword(password);
        return encryptedPassword == encryptedInput;
    }
}