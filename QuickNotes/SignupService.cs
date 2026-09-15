public class SignupService
{
    public SignupResult Signup(string email, string password)
    {
        if (!email.Contains("@"))
            return new SignupResult { Error = "invalid" };

        if (password.Length < 8)
            return new SignupResult { Error = "weak" };

        // BCrypt uses 10 work factor rounds to increase the cost of password cracking.
        string hash = BCrypt.Net.BCrypt.HashPassword(password, workFactor: 10);

        var existingUser = db.Users.FirstOrDefault(u => u.Email == email);

        if (existingUser != null)
            return new SignupResult { Error = "exists" };

        var user = db.Users.Add(new User
        {
            Email = email,
            PasswordHash = hash,
            Verified = false
        });

        // Email verification prevents an account from being treated as verified
        // until the user confirms ownership of the email address.
        SendVerificationEmail(user.Email, user.Id);

        return new SignupResult { Id = user.Id };
    }
}