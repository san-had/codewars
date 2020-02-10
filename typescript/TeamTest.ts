export function updateTeam(team: Team) {
    team.Name = "Purple";
}

export class Team {
    public Id:number;
    public Name:string;
    public Rank:number;
}

function CreateTeams(numberOfTeams: number) {
    let teamArray: Team[] = new Array<Team>();
    for (let i = 0; i < numberOfTeams; i++) {
        let team: Team = new Team();
        team.Id = i;
        //team.Vor = 0, team.Against = 0, team.Points = 0, team.Rank = 0;
        teamArray.push(team);
    }
    return teamArray;   
}