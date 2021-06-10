import { reviews } from "./review";

export interface restaurant {
    id: number;
    name: string;
    city: string;
    state: string;
    reviews: null | reviews[];
}