﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _7DTD_Remote_Server_Manager
{
    class PlayerList : RemoteServerWindow
    {
        public void PopulateList()
        {
            while (true && UserConfig.tnet.IsConnected)
            {
                UserConfig.tnet.WriteLine("lp");

                string result = UserConfig.tnet.Read();
                
                if (result.Contains("1. id"))
                {
                    int find = result.IndexOf("1. id");
                    try
                    {
                        result = result.Substring(find);
                    }
                    catch (ArgumentOutOfRangeException exp)
                    {
                        UserConfig.tnet.WriteLine("exit");
                    }

                    string[] players = Regex.Split(result, ",|\n");

                    string[] playersFiltered = new string[(int)(players.Length / 5.5)];
                    int index = 0;
                    for (int i = 0; i < players.Length; i++)
                    {

                        if (players[i].Contains("id="))
                        {
                            playersFiltered[index] = players[i].Substring(6);
                            playersFiltered[index + 1] = players[i+1].TrimStart();
                        }

                    }

                    UserConfig.players = new List<Player>();

                    for (int i = 0; i < (playersFiltered.Length / 2) - 1; i++)
                    {
                        UserConfig.players.Add(new Player(playersFiltered[i + 1], Int32.Parse(playersFiltered[i])));
                    }

                    System.Threading.Thread.Sleep(5000);

                    listPlayers.DataSource = UserConfig.players;

                    listPlayers.Refresh();
                }
            }
        }
    }
}
