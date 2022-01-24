
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FileUploadService {
  baseUrl:string = "https://localhost:44370/api"


  constructor(private http:HttpClient) { }
  
  // Returns an observable
  upload(file: string | Blob):Observable<any> {
  
      // Create form data
      const formData = new FormData(); 
        
      // Store form name as "file" with file data
      formData.append("file", file);
        
      // Make http post request over api
      // with formData as req
      return this.http.post(this.baseUrl+'/FileUpload', formData)
  }
}
