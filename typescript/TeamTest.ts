export function updateTeam(team: Team) {
    team.Name = "Purple";
}

export class Team {
    public Id:number;
    public Name:string;
    public Rank:number;
}

export function CreateTeams(numberOfTeams: number) {
    let teamArray: Team[] = new Array<Team>();
    for (let i = 0; i < numberOfTeams; i++) {
        let team: Team = new Team();
        team.Id = i;
        team.Name = "Team" + i.toString();
        teamArray.push(team);
    }
    return teamArray;   
}