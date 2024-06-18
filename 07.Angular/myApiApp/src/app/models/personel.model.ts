export class PersonelModel{
    id: number = 0;
    firstname: string = "";
    lastname: string = "";
    profession: ProfessionType = "Software";
    salary: number = 10000;
}

export type ProfessionType = 
    "Software" | 
    "Accountant" | 
    "Cleaner"