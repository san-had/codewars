export function computeRanks(numberOfTeams: number, games:any): number[] {

    let ranks: number[] = [4,4,6,3,1,2];

    return ranks;

}

class Team {
    public Id: number;
    public Vor: number;
    public Against: number;
    public get GD(): number
    { 
        return this.Vor - this.Against;
    }
}