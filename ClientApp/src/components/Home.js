import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  constructor(props) {
    super(props);
    this.state = { drinks: [], loading: true, drink: {name : '', stepsPreformed: [], issueCreatingDrink : false } };
    this.orderHotDrink = this.orderHotDrink.bind(this);
  }

  componentDidMount() {
    this.populateDrinksList();
  }

  renderDrinkButtons(drinks) {
    return (
        <div>
          {
            drinks.map((drink) =>
              <button className="btn btn-primary btn-block" onClick={() => this.orderHotDrink(drink)} key={drink.id}>{drink.name}</button>
            )            
          }

        </div>
    );
  }

  renderDrinkOrder(drink) {
    return (
      <div>
        <h2>{drink.name}</h2>
        <ul>
          {
            drink.stepsPreformed.map(step => 
              <li>{step}</li>
            )
          }
        </ul>
      </div>
    )
  }

  render () {
    let contents = this.state.loading
    ? <p><em>Loading...</em></p>
    : this.renderDrinkButtons(this.state.drinks);

    let drink = this.state.drink.issueCreatingDrink
      ? <p><em>Problem creating drink.</em></p>
      : this.renderDrinkOrder(this.state.drink);

    return (
      <div>
        <p>Please select your drink:</p>
        <div className="row">
          <div className="col-md-6">
            {contents}
          </div>
          <div className="col-md-6">
            {drink}
          </div>
        </div>
      </div>
    );
  }

  async populateDrinksList() {
    const response = await fetch('hotdrink');
    const data = await response.json();
    this.setState({ drinks: data, loading: false });
  }

  async orderHotDrink(drink) {
    const response = await fetch(`hotdrink/` + drink.id);
    const data = await response.json();
    this.setState( {drink: data} );
  }

}
