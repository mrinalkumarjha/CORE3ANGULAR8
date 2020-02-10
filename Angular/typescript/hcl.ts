export class hcltech
{
    code: number;
    name: string;

    constructor(c:number, n:string)
    {
        this.code = c;
        this.name = n;
    }

    Display(): void
    {
        console.log(this.code);
        console.log(this.name);
    }
}


export class birlasoft
{
    code: number;
    name: string;

    constructor(c:number, n:string)
    {
        this.code = c;
        this.name = n;
    }

    Display(): void
    {
        console.log(this.code);
        console.log(this.name);
    }
}

// here memory of hcl allocated in heap.
// var obj = new hcl(120, 'mrinal');
// obj.Display();