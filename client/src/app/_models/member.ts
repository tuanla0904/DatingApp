import { Photo } from './photo';

export interface Member {
  userName: string;
  gender: string;
  age: Date;
  knownAs: string;
  created: Date;
  lastActive: Date;
  introduction: string;
  lookingFor: string;
  interests: string;
  city: string;
  country: string;
  photos: Photo[];
  photoUrl: string;
}
