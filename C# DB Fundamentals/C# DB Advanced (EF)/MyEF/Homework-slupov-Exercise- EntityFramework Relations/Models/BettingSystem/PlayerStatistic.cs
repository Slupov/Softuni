﻿namespace BookmakerSystem.Model
{
    public class PlayerStatistic
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int ScoredGoals { get; set; }
        public int PlayerAssists { get; set; }
        public double PlayedMinutesDuringGame { get; set; }
    }
}
