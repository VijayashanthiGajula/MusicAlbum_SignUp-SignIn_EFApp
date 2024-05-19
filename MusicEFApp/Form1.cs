namespace MusicEFApp
{
    public partial class Form1 : Form
    {
        Home f2 = new Home();
        public Form1()
        {
            InitializeComponent();
        }
           

        private void SignIn_Click(object sender, EventArgs e)
        {
            using (var context = new MusicDBContext())
            {
                var blog = context.Users.SingleOrDefault(b =>
                    b.EmailId == emailTxt.Text &
                    b.Password == PwdTxt.Text);
                if(blog == null) 
                {
                    // User not found, show message box and ask to create new user
                    DialogResult result = MessageBox.Show("No user exists. Do you want to create a new user?", "User Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // If user chooses to create a new user, show sign-up features
                        SignUp.Visible = true;
                        NameLb.Visible = true;
                        NameTxt.Visible = true;
                        Rolelb.Visible = true;
                        RoleTxt.Visible = true;
                        SignIn.Visible = false;
                    }
                    else
                    {
                        // If user chooses not to create a new user, you can handle this case accordingly
                        // For example, you can show a message or perform other actions
                        MessageBox.Show("You chose not to create a new user. Please try again with correct credentials or sign up if you're a new user.", "Action Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    this.Hide();
                    Home f2 = new Home();
                    f2.Show();
                }
               

            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            using (var context = new MusicDBContext())
            {
                var newUser = new User
                {
                    Name = NameTxt.Text,
                    Password = PwdTxt.Text,
                    EmailId = emailTxt.Text,
                    Role = RoleTxt.Text
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                MessageBox.Show("User created successfully");

                this.Hide();               
                f2.Show();
            }
        }
    }
}
