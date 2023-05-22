using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football_homework
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Футболист, наследява Person
    public class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public FootballPlayer(string name, int age, int number, double height)
            : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }

    // Вратар, наследява FootballPlayer
    public class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    // Защитник, наследява FootballPlayer
    public class Defender : FootballPlayer
    {
        public Defender(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    // Полузащитник, наследява FootballPlayer
    public class Midfielder : FootballPlayer
    {
        public Midfielder(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    // Нападател, наследява FootballPlayer
    public class Striker : FootballPlayer
    {
        public Striker(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    // Треньор
    public class Coach : Person
    {
        public Coach(string name, int age)
            : base(name, age)
        {
        }
    }

    // Рефери
    public class Referee : Person
    {
        public Referee(string name, int age)
            : base(name, age)
        {
        }
    }

    // Отбор
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }

        public double CalculateAverageAge()
        {
            int totalAge = 0;
            foreach (FootballPlayer player in Players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / Players.Count;
        }
    }

    // Мач
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public Game(Team team1, Team team2, Referee referee)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
        }
    }
}
