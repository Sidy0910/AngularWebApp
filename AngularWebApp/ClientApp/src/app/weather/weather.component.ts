import { HttpClient, HttpParams } from "@angular/common/http";
import { Component, Inject, OnInit } from "@angular/core";
import { inject } from "@angular/core/testing";
import { WeatherModel } from "../Models/WeatherModel";

@Component({
  selector: "app-weather",
  templateUrl: "./weather.component.html",
  styleUrls: ["./weather.component.css"],
})
export class WeatherComponent implements OnInit {
  @Inject("BASE_URL")
  weatherModel: WeatherModel[];
  weatherModelCopy: WeatherModel[];
  loading: boolean;
  baseUrl: string;
  cityValue = "";

  constructor(private httpClient: HttpClient) {}

  ngOnInit() {}

  getValue(value: string) {
    console.log(value);
    this.cityValue = value;
    this.getRequest(this.cityValue);
  }

  public getRequest(value: string) {
    let wm: WeatherModel[];
    let params = new HttpParams().set("city", value);
    return this.httpClient.get<WeatherModel[]>("weather", { params }).subscribe(
      (res) => {
        wm = res;
        this.weatherModelCopy = wm;
        console.log(this.weatherModelCopy);
        console.log('sucesss...', this.weatherModel);
      },
      (error) => console.log(error)
    );
  }
}
