﻿using Pangya_Season7_GS.Handles_Packet;
using PangyaAPI;
using PangyaAPI.BinaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangya_Season7_GS.Handles
{
    public class Handle_PLAYER_LOADING_INFO : HandleBase<Packet_PLAYER_LOADING_INFO>
    {
        public Handle_PLAYER_LOADING_INFO(Player player) : base(player)
        {
            Handle();
        }

        private void Handle()
        {
            var result = new PangyaBinaryWriter();

            result.Write(new byte[] { 0xA3, 0x00 });
            result.Write(Player.ConnectionId);
            result.Write(PacketResult.Progress);

            Player.Game.Players.ForEach(p => p.SendResponse(result.GetBytes()));

            Console.WriteLine($"Percent Load: {PacketResult.Progress * 10}%");

            //SE 100%
            if (PacketResult.Progress * 10 == 80)
            {
                //TESTE VERSUS MODE
                Player.SendResponse(new byte[] { 0x9E, 0x00, 0x00, 0x00, 0x00 });//wind
                Player.SendResponse(new byte[] { 0x5B, 0x00, 0x08, 0x00, 0x2C, 0x01, 0x01 });//weather
                Player.SendResponse(new byte[] { 0x53, 0x00,
                    //sua conexao ID
                    0x00, 0x00, 0x00, 0x00 });//o primeiro há tacar

                //W_BIGBONGDARI
                Player.SendResponse(new byte[] { 0x15, 0x01, 0x0D, 0x00, 0x57, 0x5F, 0x42, 0x49, 0x47, 0x42, 0x4F, 0x4E, 0x47, 0x44, 0x41, 0x52, 0x49, 0x00, 0x02, 0x01, 0x03, 0x00, 0x03, 0x01, 0x01, 0x01, 0x03, 0x00, 0x00, 0x00, 0x02, 0x00, 0x02, 0x02, 0x01, 0x02, 0x03, 0x02, 0x03, 0x01, 0x00, 0x03, 0x01, 0x00, 0x03, 0x01, 0x02, 0x02, 0x01, 0x02, 0x01, 0x00, 0x03, 0x02, 0x02, 0x02, 0x01, 0x02, 0x02, 0x01, 0x00, 0x00, 0x03, 0x00, 0x02, 0x00, 0x03, 0x02, 0x03, 0x01, 0x00, 0x00, 0x02, 0x02, 0x00, 0x00, 0x01, 0x03, 0x02, 0x01, 0x01, 0x03, 0x01, 0x03, 0x01, 0x03, 0x03, 0x01, 0x00, 0x01, 0x00, 0x01, 0x01, 0x01, 0x00, 0x00, 0x03, 0x00, 0x02, 0x03, 0x01, 0x03, 0x03, 0x01, 0x03, 0x02, 0x03, 0x03, 0x02, 0x01, 0x02, 0x00, 0x01, 0x01, 0x01, 0x00, 0x00 });

                //R_BIGBONGDARI
                Player.SendResponse(new byte[] { 0x15, 0x01, 0x0D, 0x00, 0x52, 0x5F, 0x42, 0x49, 0x47, 0x42, 0x4F, 0x4E, 0x47, 0x44, 0x41, 0x52, 0x49, 0x00, 0x02, 0x02, 0x01, 0x03, 0x01, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x03, 0x03, 0x01, 0x00, 0x00, 0x00, 0x00, 0x03, 0x01, 0x01, 0x00, 0x03, 0x02, 0x02, 0x02, 0x01, 0x02, 0x03, 0x01, 0x01, 0x00, 0x03, 0x01, 0x01, 0x02, 0x02, 0x02, 0x00, 0x00, 0x02, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x03, 0x01, 0x01, 0x01, 0x01, 0x00, 0x03, 0x03, 0x02, 0x01, 0x02, 0x01, 0x02, 0x03, 0x00, 0x03, 0x02, 0x02, 0x00, 0x01, 0x01, 0x02, 0x03, 0x01, 0x03, 0x03, 0x00, 0x03, 0x02, 0x03, 0x03, 0x00, 0x01, 0x00, 0x02, 0x01, 0x01, 0x03, 0x03, 0x02, 0x02, 0x03, 0x00, 0x03, 0x02, 0x02, 0x00, 0x01, 0x00, 0x00, 0x01 });

                //CLUBSET_MIRACLE
                Player.SendResponse(new byte[] { 0x15, 0x01, 0x0F, 0x00, 0x43, 0x4C, 0x55, 0x42, 0x53, 0x45, 0x54, 0x5F, 0x4D, 0x49, 0x52, 0x41, 0x43, 0x4C, 0x45, 0x00, 0x03, 0x02, 0x02, 0x03, 0x00, 0x02, 0x03, 0x01, 0x02, 0x03, 0x03, 0x03, 0x00, 0x00, 0x01, 0x02, 0x00, 0x00, 0x02, 0x02, 0x02, 0x01, 0x02, 0x03, 0x03, 0x01, 0x01, 0x03, 0x03, 0x01, 0x00, 0x00, 0x01, 0x00, 0x00, 0x03, 0x01, 0x01, 0x03, 0x01, 0x02, 0x01, 0x00, 0x01, 0x02, 0x02, 0x03, 0x03, 0x02, 0x01, 0x01, 0x03, 0x02, 0x03, 0x01, 0x01, 0x01, 0x02, 0x00, 0x00, 0x01, 0x03, 0x03, 0x00, 0x01, 0x01, 0x02, 0x00, 0x02, 0x00, 0x03, 0x03, 0x00, 0x02, 0x03, 0x03, 0x01, 0x02, 0x00, 0x00, 0x03, 0x00, 0x00, 0x02, 0x02, 0x01, 0x00, 0x01, 0x00, 0x03, 0x01, 0x00, 0x00, 0x03, 0x03, 0x00, 0x01, 0x00, 0x00 });


            }
        }
    }
}
