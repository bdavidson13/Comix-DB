
module Start

open Suave

let start =
    startWebServer defaultConfig (Successful.OK "Hello World!")