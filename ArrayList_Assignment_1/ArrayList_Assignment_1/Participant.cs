using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayList_Assignment_1
{
    internal class Participant
    {
		private String participantName;
		private String participantTalent;
		private double participantScore;

		public Participant(String participantName, String participantTalent, double participantScore)
		{
			this.participantName = participantName;
			this.participantTalent = participantTalent;
			this.participantScore = participantScore;
		}

		public String getParticipantName()
		{
			return participantName;
		}

		public void setParticipantName(String participantName)
		{
			this.participantName = participantName;
		}

		public String getParticipantTalent()
		{
			return participantTalent;
		}

		public void setParticipantTalent(String participantTalent)
		{
			this.participantTalent = participantTalent;
		}

		public double getParticipantScore()
		{
			return participantScore;
		}

		public void setParticipantScore(double participantScore)
		{
			this.participantScore = participantScore;
		}

        public override string ToString()
        {
			return "Participant Name: " + getParticipantName() + ", Participant Talent: " + getParticipantTalent() + ", Participant Score: " + getParticipantScore();
		}
    }
}
