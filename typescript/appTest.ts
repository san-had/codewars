import { updateTeam } from "./TeamTest";
import { Team } from "./TeamTest";
import { CreateTeams } from "./TeamTest";

let teams: Team[] = CreateTeams(6);

let team: Team = teams[0];

updateTeam(team);

console.log(team.Name);

console.log(teams[0].Name);

