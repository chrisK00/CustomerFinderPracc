import { Photo } from "./photo";

export interface Customer {
    id: number;
    username: string;
    lookingFor: string;
    mainPhotoUrl: string;
    photos: Photo[];
}
