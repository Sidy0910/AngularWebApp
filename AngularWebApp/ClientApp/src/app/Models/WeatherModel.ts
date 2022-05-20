export class WeatherModel {
    address: string;
    days: DaysWeather[] = [];
    currentConditions: CurrentWeather[];
}

export class DaysWeather {
    dateTime: Date;
    temp: number;
    humidity: number;
    conditions: string;
    hours: HoursDay[] = [];
}

export class CurrentWeather {
    dateTime: Date;
    temp: number;
    feelslike: number;
    humidity: number;
    conditions: number;
    sunrise: number;
    sunset: number;
}

export class HoursDay {
    dew: number;
}