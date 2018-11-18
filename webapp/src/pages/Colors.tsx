import React, { Component } from "react";
import "../styles/colors.scss";

export default class Colors extends Component {
  render() {
    return (
      <div>
        <div className="swatches">
          <div className="colorbox colorbox-red">red</div>
          <div className="colorbox colorbox-lust">lust</div>
          <div className="colorbox colorbox-dark_pink">dark_pink</div>
          <div className="colorbox colorbox-orange">orange</div>
          <div className="colorbox colorbox-lava">lava</div>
        </div>
        <div className="swatches">
          <div className="colorbox colorbox-duke_blue">duke_blue</div>
          <div className="colorbox colorbox-blue_sapphire">blue_sapphire</div>
          <div className="colorbox colorbox-light_steel_blue">light_steel_blue</div>
          <div className="colorbox colorbox-light_sea_green">light_sea_green</div>
          <div className="colorbox colorbox-rackley">rackley</div>
        </div>
        <div className="swatches">
          <div className="colorbox colorbox-pastel_orange">pastel_orange</div>
          <div className="colorbox colorbox-dark_tangerine">dark_tangerine</div>
          <div className="colorbox colorbox-daffodil">daffodil</div>
        </div>
        <div className="swatches">
          <div className="colorbox colorbox-dark_gray">dark_gray</div>
          <div className="colorbox colorbox-dim_gray">dim_gray</div>
          <div className="colorbox colorbox-gunmetal">gunmetal</div>
          <div className="colorbox colorbox-light_gray">light_gray</div>
        </div>
        <div className="swatches">
          <div className="colorbox colorbox-hunter_green">hunter_green</div>
          <div className="colorbox colorbox-right_black">right_black</div>
          <div className="colorbox colorbox-dark_jungle_green">dark_jungle_green</div>
          <div className="colorbox colorbox-kombu_green">kombu_green</div>
          <div className="colorbox colorbox-palm_leaf">palm_leaf</div>
        </div>
      </div>
    );
  }
}
