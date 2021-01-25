using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiConsoleApp.DataTransferObjects;


namespace TamagotchiConsoleApp.UI
{
    class ChangeCredentialsScreen:Screen
    {
        public ChangeCredentialsScreen() : base("Change Credentials")
        {

        }
        
        public override void Show()
        {
            //Clear screen and set title (implemented by Screen Show)
            base.Show();

            //Check if the user is loged in
            if (UIMain.CurrentPlayer != null)
            {
                Console.WriteLine("Do you want to change email, username, or password?");
                Console.WriteLine("If you want to change your email press E, Press U to change your username OR press P to change your password");
                char changeCredentials = Console.ReadKey().KeyChar;
                
                if (changeCredentials == 'e' || changeCredentials == 'E')
                {
                    //Clear screen again
                    base.Show();

                    Console.WriteLine("Please enter the new email: ");
                    string newEmail = Console.ReadLine();

                    PlayerDTO tempPlayer = UIMain.api.ChangeCredentialsEmail(newEmail);
                    if (tempPlayer == null)
                    {
                        Console.WriteLine("Failed! There was an error with the Email youv'e written!");
                    }
                }

                if (changeCredentials == 'u' || changeCredentials == 'U')
                {
                    //Clear screen again
                    base.Show();

                    Console.WriteLine("Please enter the new username: ");
                    string newUsername = Console.ReadLine();

                    PlayerDTO tempPlayer = UIMain.api.ChangeCredentialsUsername(newUsername);
                    if (tempPlayer == null)
                    {
                        Console.WriteLine("Failed! There was an error with the Username youv'e written!");
                    }
                }

                if (changeCredentials == 'p' || changeCredentials == 'P')
                {
                    //Clear screen again
                    base.Show();

                    Console.WriteLine("Please enter the new password: ");
                    string newPassword = Console.ReadLine();

                    PlayerDTO tempPlayer = UIMain.api.ChangeCredentialsPassword(newPassword);
                    if (tempPlayer == null)
                    {
                        Console.WriteLine("Failed! There was an error with the Password youv'e written!");
                    }
                }


            }

            //Show main menu once user changed his Credentials
            MainMenu menu = new MainMenu();
            menu.Show();
        }    
    }
}
