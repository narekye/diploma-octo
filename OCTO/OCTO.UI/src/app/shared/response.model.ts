export class ResponseModel<T> {
    public Data : T;
    public HasError: boolean;
    public Message: string;
    public Status: string;
}