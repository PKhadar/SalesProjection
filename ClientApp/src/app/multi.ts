export interface MultiFull {
    multi: Multi[];
}

export interface Multi {
    name: string;
    series: Series[];
}

export interface Series {
    name: string;
    value: number;
}