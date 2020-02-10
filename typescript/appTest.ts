import { updateTeam } from "./TeamTest";
import { Team } from "./TeamTest";

let team: Team = new Team();

team.Name = "Lemon";

updateTeam(team);

console.log(team.Name);
