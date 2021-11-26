using DesignPatternMediator.ChatApp;
using DesignPatternMediator.Structural;
using System;

namespace DesignPatternMediator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var teamChat = new TeamChatroom();

            var steve = new Developer("Steve");
            var justin = new Developer("Justin");
            var jenna = new Developer("Jenna");
            var kim = new Tester("Kim");
            var julia = new Tester("Julia");
            teamChat.RegisterMembers(steve, justin, jenna, kim, julia);

            steve.Send("Hey everyone, we're going to be deploying at 2pm today.");
            kim.Send("Ok, thanks for letting us know");

            steve.SendTo<Developer>("We have a problem!");
        }

        private static void Structural()
        {
            //Execute Structura = new StructuralService();
            //Structura.Run();

            //IProgram<StructuralService> _Structural = new StructuralService();
            //_Structural.Run();
        }
    }
}
