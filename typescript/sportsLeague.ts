export function computeRanks(numberOfTeams: number, games:number[][]): number[] {

    let teams = CreateTeams(numberOfTeams);

    for (let i = 0; i < games.length; i++) {
        let team1 = teams[games[i][0]];
        let team2 = teams[games[i][1]];

        let team1Score = games[i][2];
        let team2Score = games[i][3];

        team1 = UpdateTeam(team1, team1Score, team2Score);
        team2 = UpdateTeam(team2, team2Score, team1Score);

        teams[games[i][0]] = team1;
        teams[games[i][1]] = team2;
    }

    let updatedTeams = UpdateTeamRanks(teams);

    displayTeams(updatedTeams);

    let ranks: number[] = getRanks(updatedTeams);

    return ranks;

}

function getRanks(teams: Array<Team>) {
    let ranks: number[] = [];
    for (let team of teams) {
        ranks.push(team.Rank);
    }
    return ranks;
}

function displayTeams(teams: Array<Team>) {
    for(let team of teams) {
        console.log("Team" + team.Id.toString() + " " + team.Vor.toString() + " : " + team.Against.toString() + 
        " " + team.GD.toString() + " " + team.Points.toString() + " " + team.Rank.toString());
        
    }
}

function UpdateTeamRanks(teams: Array<Team>) {
    let rank: number = 1;

    let sortedTeams: Array<Team> = teams.sort((team1, team2) => {
        return team1.compareTo(team2);
    })

    let sortedTeamLength = sortedTeams.length;
    for (let index = 0; index < sortedTeamLength; index++) {
        let teamIndex = sortedTeams[index].Id;
        teams[teamIndex].Rank = rank;
        let nextIsEqual = (index + 1 < sortedTeamLength) && IsEqual(sortedTeams[index], sortedTeams[index + 1]);
        let rankGap = 0;
        while(nextIsEqual) {
            let nextTeamIndex = sortedTeams[index + 1].Id;
            teams[nextTeamIndex].Rank = rank;
            index++;
            nextIsEqual = (index + 1 < sortedTeamLength) && IsEqual(sortedTeams[index], sortedTeams[index + 1]);
            rankGap++;
        }
        rank += rankGap;
        rank++;
    }
    return teams;
}

function IsEqual(teamA: Team, teamB: Team) {
    if(teamA.Points === teamB.Points && teamA.GD === teamB.GD && teamA.Vor === teamB.Vor) {
        return true;
    }
    return false;
}

function UpdateTeam(team: Team, vor: number, against: number): Team {
    team.Vor += vor;
    team.Against += against;
    team.Points += vor === against ? 1 : vor > against ? 2 : 0;
    return team;
}

function CreateTeams(numberOfTeams: number) {
    let teamArray: Team[] = new Array<Team>();
    for (let i = 0; i < numberOfTeams; i++) {
        let team: Team = new Team();
        team.Id = i;
        team.Vor = 0, team.Against = 0, team.Points = 0, team.Rank = 0;
        teamArray.push(team);
    }
    return teamArray;
}

class Team {
    public Id: number;
    public Vor: number;
    public Against: number;
    public get GD(): number
    { 
        return this.Vor - this.Against;
    }
    public Points: number;
    public Rank: number;

    compareTo(other: Team):number {
        if (other === null) {
            throw new Error("Nullreference exception");
        }
        let result = this.compareValues(this.Points, other.Points);
        if (result != 0) {
            return result;
        }

        result = this.compareValues(this.GD, other.GD);
        if (result != 0) {
            return result;
        }
        
        result = this.compareValues(this.Vor, other.Vor);      
        return result;
    }

    compareValues(a: number, b:number) {
        return a < b ? 1 : a > b ? -1 : 0;
    }
}