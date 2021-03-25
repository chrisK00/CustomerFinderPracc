import { Photo } from "./photo";

export interface Member {
    id: number;
    username: string;
    lookingFor: string;
    mainPhotoUrl: string;
    photos: Photo[];
}
