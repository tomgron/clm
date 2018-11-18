import React, { Component } from "react"
import "./colors.scss"

export default class Colors extends Component {
  render() {
    return (
    <div>
        <div className="swatches">
            <div className="colorbox colorbox-red"></div>
            <div className="colorbox colorbox-lust"></div>
            <div className="colorbox colorbox-dark_pink"></div>
            <div className="colorbox colorbox-orange"></div>
            <div className="colorbox colorbox-lava"></div>
        </div>
        <div className="swatches">
            <div className="colorbox colorbox-duke_blue"></div>
            <div className="colorbox colorbox-blue_sapphire"></div>
            <div className="colorbox colorbox-light_steel_blue"></div>
            <div className="colorbox colorbox-light_sea_green"></div>
            <div className="colorbox colorbox-rackley"></div>
        </div>
        <div className="swatches">
            <div className="colorbox colorbox-pastel_orange"></div>
            <div className="colorbox colorbox-dark_tangerine"></div>
            <div className="colorbox colorbox-daffodil"></div>
        </div>
        <div className="swatches">
            <div className="colorbox colorbox-dark_gray"></div>
            <div className="colorbox colorbox-dim_gray"></div>
            <div className="colorbox colorbox-gunmetal"></div>
            <div className="colorbox colorbox-light_gray"></div>
        </div>
        <div className="swatches">
            <div className="colorbox colorbox-hunter_green"></div>
            <div className="colorbox colorbox-right_black"></div>
            <div className="colorbox colorbox-dark_jungle_green"></div>
            <div className="colorbox colorbox-kombu_green"></div>
            <div className="colorbox colorbox-palm_leaf"></div>
        </div>
    </div>
    )
  }
}
