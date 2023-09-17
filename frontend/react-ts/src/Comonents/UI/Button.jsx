const Button = (props) => {
    return(
        <button className="image-button" onClick={props.action}>
            {props.children}
        </button>
    )
}

export default Button;