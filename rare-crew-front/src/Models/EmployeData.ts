export default class EmployeeData{
    private _name:string;
    private _totalHoursWorked: number;
    public get name():string{
        return this._name;
    }
    public set name(value:string){
        this._name=value;
    }
    public get totalHoursWorked(): number {
        return this._totalHoursWorked;
    }
    public set totalHoursWorked(value: number) {
        this._totalHoursWorked = value;
    }

    constructor(employeeName:string,hoursWorked:number){
        this._name=employeeName;
        this._totalHoursWorked=hoursWorked;
    }
}